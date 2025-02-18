using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCreational.Entities.Task
{
    public class Query
    {
        public string Table { get; set; }
        public string[]? Fields { get; set; }
        public string? Condition { get; set; }
        public string? OrderBy { get; set; }
        public int? Limit { get; set; }
        
        public string Execute() 
        {
            if (Fields == null)
            {
                return $"SELECT * FROM {this.Table} WHERE {this.Condition} ORDER BY {this.OrderBy} LIMIT {this.Limit}";
            }
            else 
            {
                return $"SELECT ({string.Join(",", this.Fields)}) FROM {this.Table} WHERE {this.Condition} ORDER BY {this.OrderBy} LIMIT {this.Limit}";
            }
        } 
    }
    public class QueryBuilder
    {
        private Query _query;
        public QueryBuilder(string table)
        {
            _query = new Query();
            _query.Table = table;
        }
        public QueryBuilder select(string[]? fields = null)
        {
            this._query.Fields = fields;
            return this;
        }

        public QueryBuilder where(string condition)
        {
            if (this._query.Condition != null)
            {
                this._query.Condition = $"{this._query.Condition} AND {condition}";
            }
            else
            {
                this._query.Condition = condition;
            }
            return this;
        }

        public QueryBuilder orderBy(string field, string order)
        {
            this._query.OrderBy = $"{field} {order}";
            return this;
        }

        public QueryBuilder limit(int limit)
        {
            this._query.Limit = limit;
            return this;
        }

        public Query Build()
        {
            return this._query;
        }


    }
}
