using API_Reconnect.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Reconnect.Data
{
    public class SeedDataConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasData(
                new Usuario { Id= 1, Nome= "Irineu Júnior", Email= "irineu@com", Senha= "123", Telefone="(12)98734-5678", Profissao= "Motorista", Cpf="123.456.789-98", Endereco= "Rua do Gatos, n. 0", DataNascimento= DateTime.Parse("1985-03-13"), Bio = "Faço transporte particular para eventos, viagens e empresas.", Foto = "https://media.licdn.com/dms/image/C4D03AQH5__8lovq3Qw/profile-displayphoto-shrink_800_800/0/1521630576802?e=2147483647&v=beta&t=Sl_AZe5Cy1MvCT5yEKQcqpyDOHDPpvl8WiSDEj-YE0k" },
                new Usuario { Id = 2, Nome = "Carol Danvers", Email = "carol@com", Senha = "123", Telefone = "(97)98754-9548", Profissao = "Professor(a)", Cpf = "123.874.965-35", Endereco = "Av. dos Viajantes, n. 1010", DataNascimento = DateTime.Parse("1965-08-20"), Bio = "Ensino Matemática e Física para crianças, jovens e adultos.", Foto = "https://i.pinimg.com/236x/a5/80/da/a580daf4f797e10a4e5443915bedba86.jpg" },
                new Usuario { Id = 3, Nome = "Steve Rogers", Email = "steve@com", Senha = "123", Telefone = "(97)97541-6532", Profissao = "Pedreiro", Cpf = "987.874.965-12", Endereco = "Av. Capitão América, n. 450", DataNascimento = DateTime.Parse("1942-07-25"), Bio = "Faço sua casa virar um paraíso!", Foto = "https://i.pinimg.com/originals/36/01/b3/3601b349f9f4b95528d7a85104c5ff15.jpg" },

                new Usuario { Id = 4, Nome = "Marinete D.", Email = "marinete@com", Senha = "123", Telefone = "(11)985791-6965", Profissao = "Diarista", Cpf = "123.654.964-75", Endereco = "Rua Clean, n. 200", DataNascimento = DateTime.Parse("1983-11-10"), Bio = "Limpo de tudo. Agenda livre para fins de semana!", Foto = "https://www.estrelando.com.br/uploads/2016/09/08/7-1473346686.gallery.jpg" },
                new Usuario { Id = 5, Nome = "Jax Teller", Email = "jax@com", Senha = "123", Telefone = "(14)98751-6428", Profissao = "Mecânico", Cpf = "987.345.965-98", Endereco = "Av. Charming, n. 120", DataNascimento = DateTime.Parse("1980-02-05"), Bio = "Sou profissional de motos, mais de 20 anos de experiência.", Foto = "https://i.pinimg.com/736x/64/da/ab/64daab7bb0a107904f21831a0a7a9483.jpg" },
                new Usuario { Id = 6, Nome = "Mário B.", Email = "mario@com", Senha = "123", Telefone = "(44)97515-6532", Profissao = "Encanador", Cpf = "987.874.978-01", Endereco = "Rua dos Canos, n. 450", DataNascimento = DateTime.Parse("1990-06-17"), Bio = "Melhor encanador do bairro! Aceito todo tipo de trabalho.", Foto = "https://image-cdn.essentiallysports.com/wp-content/uploads/Mario-The-last-of-us-180x180.jpg" },
                new Usuario { Id = 7, Nome = "Natasha  R.", Email = "natasha@com", Senha = "123", Telefone = "(97)97854-6578", Profissao = "Personal Trainer", Cpf = "875.874.568-02", Endereco = "Av. Rua dos Exercícios, n. 85", DataNascimento = DateTime.Parse("1981-02-01"), Bio = "Personal trainer para emagrecimento e definição.", Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTkNfq2S8h30n1dyTHFT4b1WfK41cB7lzFdyEuSPRz2W-vA94FEH9urevekbXg5EFbXQQ8&usqp=CAU" },
                new Usuario { Id = 8, Nome = "Patricia F.", Email = "patsferrer@com", Senha = "123", Telefone = "(85)89547-5478", Profissao = "Marmiteira", Cpf = "986.742.123-03", Endereco = "Av. Panqueca, 7845", DataNascimento = DateTime.Parse("2010-10-07"), Bio = "Cozinho com amor! Aceito encomendas, ganha brinde.", Foto = "https://patsferrer.github.io/49ers/src/images/perfis/perfil09.png" }


            );
        }
    }
}
