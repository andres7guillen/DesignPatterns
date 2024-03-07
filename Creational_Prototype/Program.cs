using CreationalDomain.Entities.Prototype;

//SUPERFICIAL.
UsuarioSuperficial user = new UsuarioSuperficial();
user.Nombre = "Andrés";
user.Apellido = "Guillén";
user.Id = Guid.NewGuid();
user.ProfilePhoto = new Photo();
user.ProfilePhoto.Url = "www.image.com";
user.ProfilePhoto.Descripcion = "Vacaciones";



UsuarioSuperficial userCloned = user.Clone() as UsuarioSuperficial;
userCloned.Nombre = "Andres Cloned";
userCloned.Apellido = "Guillen Cloned";
userCloned.ProfilePhoto.Url = "www.cloned.com";
userCloned.ProfilePhoto.Descripcion = "Vacaciones cloned";

Console.WriteLine($"User superficial creado: {user.ProfilePhoto.Descripcion}");
Console.WriteLine($"User superficial clonado: {userCloned.ProfilePhoto.Descripcion}");

/////////////////////PROFUNDO////////////////////////////////////////
UsuarioProfundo userProfundo = new UsuarioProfundo();
userProfundo.Nombre = "Andrés";
userProfundo.Apellido = "Guillén";
userProfundo.Id = Guid.NewGuid();
userProfundo.ProfilePhoto = new Photo();
userProfundo.ProfilePhoto.Url = "www.image.com";
userProfundo.ProfilePhoto.Descripcion = "Vacaciones";

UsuarioProfundo userProfundoCloned = userProfundo.Clone() as UsuarioProfundo;
userProfundoCloned.Nombre = "Andres Cloned";
userProfundoCloned.Apellido = "Guillen Cloned";
userProfundoCloned.ProfilePhoto.Url = "www.cloned.com";
userProfundoCloned.ProfilePhoto.Descripcion = "Vacaciones cloned";

Console.WriteLine($"User profundo creado: {userProfundo.ProfilePhoto.Descripcion}");
Console.WriteLine($"User profundo clonado: {userProfundoCloned.ProfilePhoto.Descripcion}");

