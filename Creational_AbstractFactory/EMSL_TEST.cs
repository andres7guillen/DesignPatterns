//using CSharpFunctionalExtensions;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Creational_AbstractFactory
//{
//    public class ReferenceSample : AggregateRoot
//    {
//        #region Backing fields for Entity Framework, because it has a bug for Fluent Config. HasConverter() with Nulls

//        private long? _basedOnIdOfSampleInClientOrder = null;
//        private long? _basedOnPLMPTInfo = null;
//        private long? _basedOnPLMNOBPTInfo = null;
//        private long? _basedOnTEMNOBPTInfo = null;
//        private long? _basedOnBlankInfo = null;

//        private long? _methodId = null;
//        private long? _testId = null;
//        private long? _matrixId = null;

//        #endregion

//        public long IdOfAnalysisGroupInLab { get; }
//        public string IdInLab { get; private set; }
//        public ReferenceSampleOrigin Origin { get; }
//        public ReferenceSampleStatus Status { get; private set; }

//        public Maybe<AnalysisTuple> Analysis => GetAnalysisTuple();

//        public Maybe<long> BasedOnIdOfSampleInClientOrder
//        {
//            get => Utilities.GetBackingField(this._basedOnIdOfSampleInClientOrder);
//            private set => value.SetBackingField(out this._basedOnIdOfSampleInClientOrder);
//        }

//        public Maybe<long> BasedOnPLMPTInfo
//        {
//            get => Utilities.GetBackingField(this._basedOnPLMPTInfo);
//            private set => value.SetBackingField(out this._basedOnPLMPTInfo);
//        }

//        public Maybe<long> BasedOnPLMNOBPTInfo
//        {
//            get => Utilities.GetBackingField(this._basedOnPLMNOBPTInfo);
//            private set => value.SetBackingField(out this._basedOnPLMNOBPTInfo);
//        }

//        public Maybe<long> BasedOnTEMNOBPTInfo
//        {
//            get => Utilities.GetBackingField(this._basedOnTEMNOBPTInfo);
//            private set => value.SetBackingField(out this._basedOnTEMNOBPTInfo);
//        }

//        public Maybe<long> BasedOnBlankInfo
//        {
//            get => Utilities.GetBackingField(this._basedOnBlankInfo);
//            private set => value.SetBackingField(out this._basedOnBlankInfo);
//        }

//        private readonly List<ReferenceSampleProficiencyTestAnalysis> _proficiencyTestAnalyses = new List<ReferenceSampleProficiencyTestAnalysis>();
//        public ICollection<ReferenceSampleProficiencyTestAnalysis> ProficiencyTestAnalyses => _proficiencyTestAnalyses.ToList();

//        private readonly List<ReferenceSampleBlankAnalysis> _blankAnalyses = new List<ReferenceSampleBlankAnalysis>();
//        public ICollection<ReferenceSampleBlankAnalysis> BlankAnalyses => _blankAnalyses.ToList();

//        private ReferenceSample() { }

//        private ReferenceSample(long withIdOfAnalysisGroupInLab,
//                                string withIdInLab,
//                                Maybe<long> withBasedOnIdOfSampleInClientOrder,
//                                ReferenceSampleOrigin withOrigin,
//                                ReferenceSampleStatus withStatus,
//                                AnalysisTuple withAnalysisTuple,
//                                Maybe<long> withBasedOnPLMPTInfo,
//                                Maybe<long> withBasedOnPLMNobPTInfo,
//                                Maybe<long> withBasedOnTEMNobPTInfo,
//                                Maybe<long> withBasedOnAsbestosBlankInfo,
//                                Maybe<List<ReferenceSampleProficiencyTestAnalysis>> withAnalyses,
//                                Maybe<List<ReferenceSampleBlankAnalysis>> withBlankAnalyses)
//        {
//            this.IdInLab = withIdInLab;
//            this.IdOfAnalysisGroupInLab = withIdOfAnalysisGroupInLab;
//            this.BasedOnIdOfSampleInClientOrder = withBasedOnIdOfSampleInClientOrder;
//            this.Origin = withOrigin;
//            this.Status = withStatus;
//            this.BasedOnPLMPTInfo = withBasedOnPLMPTInfo;
//            this.BasedOnPLMNOBPTInfo = withBasedOnPLMNobPTInfo;
//            this.BasedOnTEMNOBPTInfo = withBasedOnTEMNobPTInfo;
//            this.BasedOnBlankInfo = withBasedOnAsbestosBlankInfo;

//            if (withAnalysisTuple != null)
//            {
//                this._methodId = withAnalysisTuple.MethodId;
//                this._testId = withAnalysisTuple.TestId.Value;
//                this._matrixId = withAnalysisTuple.MatrixId.Value;
//            }

//            if (withAnalyses.HasValue)
//                this._proficiencyTestAnalyses = withAnalyses.Value;

//            if (withBlankAnalyses.HasValue)
//                this._blankAnalyses = withBlankAnalyses.Value;
//        }

//        internal static Result<ReferenceSample> CreateFromExistingSampleInClientOrder(
//                                                    AnalysisGroupInLaboratory intoAnalysisGroupInLab,
//                                                    string withIdInLab,
//                                                    SampleInClientOrder basedOnSampleInClientOrder,
//                                                    AnalysisTuple plannedAnalysis)
//        {
//            if (basedOnSampleInClientOrder == null)
//                return Result.Failure<ReferenceSample>("Please provide a Client Sample");

//            if (intoAnalysisGroupInLab == null)
//                return Result.Failure<ReferenceSample>("Please provide an Analysis Group in Lab");

//            if (plannedAnalysis == null)
//                return Result.Failure<ReferenceSample>("Please provide an Analysis Tuple");

//            var result = ValidateIdInLab(withIdInLab);
//            if (result.IsFailure)
//                return Result.Failure<ReferenceSample>(result.Error);

//            return new ReferenceSample(withIdOfAnalysisGroupInLab: intoAnalysisGroupInLab.Id,
//                                        withIdInLab: withIdInLab,
//                                        withBasedOnIdOfSampleInClientOrder: basedOnSampleInClientOrder.Id,
//                                        withOrigin: ReferenceSampleOrigin.FromASampleInOrder,
//                                        withStatus: ReferenceSampleStatus.Pending,
//                                        withAnalysisTuple: plannedAnalysis,
//                                        withBasedOnPLMPTInfo: Maybe<long>.None,
//                                        withBasedOnPLMNobPTInfo: Maybe<long>.None,
//                                        withBasedOnTEMNobPTInfo: Maybe<long>.None,
//                                        withBasedOnAsbestosBlankInfo: Maybe<long>.None,
//                                        withAnalyses: Maybe<List<ReferenceSampleProficiencyTestAnalysis>>.None,
//                                        withBlankAnalyses: Maybe<List<ReferenceSampleBlankAnalysis>>.None);
//        }

//        internal static Result<ReferenceSample> CreateFromPLMProficiencyTest(
//                                            AggregateRootReference intoAnalysisGroupInLab,
//                                            string withIdInLab,
//                                            AggregateRootReference basedOnPTInfoId,
//                                            List<ReferenceSampleProficiencyTestAnalysis> withAnalyses)
//        {
//            if (basedOnPTInfoId == null)
//                return Result.Failure<ReferenceSample>("Please provide a Client Sample");

//            if (intoAnalysisGroupInLab == null)
//                return Result.Failure<ReferenceSample>("Please provide an Analysis Group in Lab");

//            if (withAnalyses == null)
//                return Result.Failure<ReferenceSample>("Please provide an Analysis Tuple");

//            var result = ValidateIdInLab(withIdInLab);
//            if (result.IsFailure)
//                return Result.Failure<ReferenceSample>(result.Error);

//            return new ReferenceSample(withIdOfAnalysisGroupInLab: intoAnalysisGroupInLab.ReferenceId,
//                                        withIdInLab: withIdInLab,
//                                        withOrigin: ReferenceSampleOrigin.FromProficiencyTest,
//                                        withStatus: ReferenceSampleStatus.Active,
//                                        withAnalysisTuple: null,
//                                        withBasedOnPLMPTInfo: basedOnPTInfoId.ReferenceId,
//                                        withBasedOnPLMNobPTInfo: Maybe<long>.None,
//                                        withBasedOnIdOfSampleInClientOrder: Maybe<long>.None,
//                                        withBasedOnTEMNobPTInfo: Maybe<long>.None,
//                                        withBasedOnAsbestosBlankInfo: Maybe<long>.None,
//                                        withAnalyses: withAnalyses,
//                                        withBlankAnalyses: Maybe<List<ReferenceSampleBlankAnalysis>>.None);
//        }

//        internal static Result<ReferenceSample> CreateFromPLMNOBProficiencyTest(
//                                            AggregateRootReference intoAnalysisGroupInLab,
//                                            string withIdInLab,
//                                            AggregateRootReference basedOnPTInfoId,
//                                            List<ReferenceSampleProficiencyTestAnalysis> withAnalyses)
//        {
//            if (basedOnPTInfoId == null)
//                return Result.Failure<ReferenceSample>("Please provide a Client Sample");

//            if (intoAnalysisGroupInLab == null)
//                return Result.Failure<ReferenceSample>("Please provide an Analysis Group in Lab");

//            if (withAnalyses == null)
//                return Result.Failure<ReferenceSample>("Please provide an Analysis Tuple");

//            var result = ValidateIdInLab(withIdInLab);
//            if (result.IsFailure)
//                return Result.Failure<ReferenceSample>(result.Error);

//            return new ReferenceSample(withIdOfAnalysisGroupInLab: intoAnalysisGroupInLab.ReferenceId,
//                                        withIdInLab: withIdInLab,
//                                        withOrigin: ReferenceSampleOrigin.FromProficiencyTest,
//                                        withStatus: ReferenceSampleStatus.Active,
//                                        withAnalysisTuple: null,
//                                        withBasedOnPLMPTInfo: Maybe<long>.None,
//                                        withBasedOnPLMNobPTInfo: basedOnPTInfoId.ReferenceId,
//                                        withBasedOnIdOfSampleInClientOrder: Maybe<long>.None,
//                                        withBasedOnTEMNobPTInfo: Maybe<long>.None,
//                                        withBasedOnAsbestosBlankInfo: Maybe<long>.None,
//                                        withAnalyses: withAnalyses,
//                                        withBlankAnalyses: Maybe<List<ReferenceSampleBlankAnalysis>>.None);
//        }

//        internal static Result<ReferenceSample> CreateFromTEMNOBProficiencyTest(
//                                            AggregateRootReference intoAnalysisGroupInLab,
//                                            string withIdInLab,
//                                            AggregateRootReference basedOnPTInfoId,
//                                            List<ReferenceSampleProficiencyTestAnalysis> withAnalyses)
//        {
//            if (basedOnPTInfoId == null)
//                return Result.Failure<ReferenceSample>("Please provide a Client Sample");

//            if (intoAnalysisGroupInLab == null)
//                return Result.Failure<ReferenceSample>("Please provide an Analysis Group in Lab");

//            if (withAnalyses == null)
//                return Result.Failure<ReferenceSample>("Please provide an Analysis Tuple");

//            var result = ValidateIdInLab(withIdInLab);
//            if (result.IsFailure)
//                return Result.Failure<ReferenceSample>(result.Error);

//            return new ReferenceSample(withIdOfAnalysisGroupInLab: intoAnalysisGroupInLab.ReferenceId,
//                                        withIdInLab: withIdInLab,
//                                        withOrigin: ReferenceSampleOrigin.FromProficiencyTest,
//                                        withStatus: ReferenceSampleStatus.Active,
//                                        withAnalysisTuple: null,
//                                        withBasedOnPLMPTInfo: Maybe<long>.None,
//                                        withBasedOnPLMNobPTInfo: Maybe<long>.None,
//                                        withBasedOnIdOfSampleInClientOrder: Maybe<long>.None,
//                                        withBasedOnAsbestosBlankInfo: Maybe<long>.None,
//                                        withBasedOnTEMNobPTInfo: basedOnPTInfoId.ReferenceId,
//                                        withAnalyses: withAnalyses,
//                                        withBlankAnalyses: Maybe<List<ReferenceSampleBlankAnalysis>>.None);
//        }

//        internal static Result<ReferenceSample> CreateFromAsbestosBlank(
//                                            AggregateRootReference intoAnalysisGroupInLab,
//                                            string withIdInLab,
//                                            AggregateRootReference basedOnBlanknInfoId,
//                                            List<ReferenceSampleBlankAnalysis> withBlankAnalyses)
//        {
//            if (basedOnBlanknInfoId == null)
//                return Result.Failure<ReferenceSample>("Please provide a Client Sample");

//            if (intoAnalysisGroupInLab == null)
//                return Result.Failure<ReferenceSample>("Please provide an Analysis Group in Lab");

//            if (withBlankAnalyses == null)
//                return Result.Failure<ReferenceSample>("Please provide an Analysis Tuple");

//            var result = ValidateIdInLab(withIdInLab);
//            if (result.IsFailure)
//                return Result.Failure<ReferenceSample>(result.Error);

//            return new ReferenceSample(withIdOfAnalysisGroupInLab: intoAnalysisGroupInLab.ReferenceId,
//                                        withIdInLab: withIdInLab,
//                                        withOrigin: ReferenceSampleOrigin.FromBlank,
//                                        withStatus: ReferenceSampleStatus.Pending,
//                                        withAnalysisTuple: null,
//                                        withBasedOnPLMPTInfo: Maybe<long>.None,
//                                        withBasedOnPLMNobPTInfo: Maybe<long>.None,
//                                        withBasedOnIdOfSampleInClientOrder: Maybe<long>.None,
//                                        withBasedOnTEMNobPTInfo: Maybe<long>.None,
//                                        withBasedOnAsbestosBlankInfo: basedOnBlanknInfoId.ReferenceId,
//                                        withAnalyses: Maybe<List<ReferenceSampleProficiencyTestAnalysis>>.None,
//                                        withBlankAnalyses: withBlankAnalyses);
//        }

//        public Result RetireReferenceSample()
//        {
//            if (this.Status == ReferenceSampleStatus.Retired)
//                return Result.Failure("Reference sample is already retired");

//            this.Status = ReferenceSampleStatus.Retired;
//            return Result.Success();
//        }

//        public Result ActivateReferenceSample()
//        {
//            if (this.Status == ReferenceSampleStatus.Retired)
//                return Result.Failure("Reference sample is Retired");

//            if (this.Status == ReferenceSampleStatus.Active)
//                return Result.Failure("Reference sample is already Activated");

//            this.Status = ReferenceSampleStatus.Active;
//            return Result.Success();
//        }

//        public Result RenameReferenceSample(string withIdInLab)
//        {
//            if (this.Status != ReferenceSampleStatus.Active && this.Status != ReferenceSampleStatus.Pending)
//                return Result.Failure("The Status of the Reference Sample is not Active or Initial");

//            var result = ValidateIdInLab(withIdInLab);
//            if (result.IsFailure)
//                return Result.Failure<ReferenceSample>(result.Error);

//            this.IdInLab = withIdInLab;
//            return Result.Success();
//        }

//        #region Validators

//        public static Result ValidateIdInLab(string value) =>
//           Utilities.ValidateString(value: value, isItRequired: true,
//               field: "Id In Lab", minLength: 1, maxLength: 10);
//        #endregion

//        #region Backing fields methods
//        private Maybe<AnalysisTuple> GetAnalysisTuple()
//        {
//            if (!_testId.HasValue || !_matrixId.HasValue || !_methodId.HasValue)
//                return Maybe<AnalysisTuple>.None;

//            return AnalysisTuple
//                .Create(methodId: _methodId.Value, matrixId: _matrixId.Value, testId: _testId.Value)
//                .Value;
//        }
//        #endregion
//    }
//}
