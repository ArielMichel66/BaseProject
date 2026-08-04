using System.ComponentModel;

namespace BaseProject.Shared.Enums;

public enum UserType
{
    [Description("Super Administrador")]
    SuperAdmin,

    [Description("Administrador")]
    Admin,

    [Description("Usuario")]
    User
}