using locamais.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace locamais.Controllers
{
    [ApiController]
    [Route("[controller]")]


  
    public class CadastraImvl
    {
        [HttpPost]
        public string CadastraImovel(string nome, string valor, string rua, string bairro, string numero, string cidade, string estado, int qtdQuartos, int qtdBanheiros, string infoAdc)
        {
            DataContext context = new DataContext();

            Random randNum = new Random();

            var Nome = nome;
            var Valor = valor;
            var Rua= rua;
            var Bairro = bairro;
            var Numero = numero;
            var Cidade = cidade;
            var Estado = estado;
            var QtdQuartos = qtdQuartos;
            var QtdBanheiros = qtdBanheiros;
            var InfoAdc = infoAdc;

            var imovel = new cadImovel()
            {
                Id = randNum.Next(),
                Nome = Nome,
                ValorAluguel = Valor,
                Endereco = Rua + "," + Numero + ", " + Bairro + " - " + Cidade + " - " + Estado,
                QtdQuartos = QtdQuartos,
                QtdBanheiros = QtdBanheiros,
                InfoAdicionais = InfoAdc,
                NomeLocatario = "",
                NumeroLocatario = "", 
                CpfLocatario = "",
                Disponibilidade = "Disponível"


            };

            context.imoveis.Add(imovel);
            context.SaveChanges();

            return "Imóvel Cadastrado !";
        }



        [HttpGet]
        public List<cadImovel> VerImoveis()
        {
            DataContext context = new DataContext();

            List<cadImovel> ImoveisCadastrados = new List<cadImovel>();

        
           string Nome = "";
           string Valor = "";
           string Rua = "";
           string Bairro = "";
           string Numero = "";
           string Cidade = "";
           string Estado = "";
           int QtdQuartos = 0;
           int QtdBanheiros = 0;
           string InfoAdc = "";

            SqlConnection con = new SqlConnection("server=DESKTOP-278IVMV;database=LOCAMAIS_IMOVEIS;trusted_connection=true;user=DESKTOP-278IVMV\\55319");

            con.Open();

            SqlCommand comando = new SqlCommand("SELECT *  FROM Imoveis", con);

            SqlDataReader DTR = comando.ExecuteReader();

            

            while (DTR.Read())
            {
                var imovel = new cadImovel();
                imovel.Nome = DTR["Nome"].ToString();
                imovel.Disponibilidade = DTR["Disponibilidade"].ToString();
                imovel.ValorAluguel = DTR["ValorAluguel"].ToString();
                imovel.Endereco = DTR["Endereco"].ToString();
                imovel.QtdQuartos =  Convert.ToInt32(DTR["QtdQuartos"]);
                imovel.QtdBanheiros = Convert.ToInt32(DTR["QtdQuartos"]);


                ImoveisCadastrados.Add(imovel);

            }

                con.Close();


            return ImoveisCadastrados;
        }


    }
}
