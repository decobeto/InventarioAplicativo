using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;


namespace InventarioAplicativo.Models
{
    public class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Secret123";

        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            //Objeto gerenciador do usuario baseado no registro do serviço do identity
            UserManager<IdentityUser> userManager = app.ApplicationServices.GetRequiredService<UserManager<IdentityUser>>();

            //Busca o usuario especifico de acordo com sua id de login
            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            if (user == null)
            {
                //Instanciando um novo usuário baseado no login informado
                user = new IdentityUser(adminUser);
                //Criando/Registrando o novo usuário com a sua senha
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}
