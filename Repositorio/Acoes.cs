using System;
using System.Collections.Generic;
using ProjetoLojaJogos.Models;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;

namespace ProjetoLojaJogos.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarJogo(Jogo jogo)
        {
            cmd = new MySqlCommand("insert into tbJogo values(@CodJogo, @Nome, @versao, @desenvolvedor, @genero, @faixaetaria, @plataforma, @dtlanc, @descricao)", con.ConectarBD());
            cmd.Parameters.Add("@CodJogo", MySqlDbType.Int32).Value = jogo.CodJogo;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = jogo.Nome;
            cmd.Parameters.Add("@versao", MySqlDbType.VarChar).Value = jogo.versao;
            cmd.Parameters.Add("@desenvolvedor", MySqlDbType.VarChar).Value = jogo.desenvolvedor;
            cmd.Parameters.Add("@genero", MySqlDbType.VarChar).Value = jogo.genero;
            cmd.Parameters.Add("@faixaetaria", MySqlDbType.Int32).Value = jogo.faixaetaria;
            cmd.Parameters.Add("@plataforma", MySqlDbType.VarChar).Value = jogo.plataforma;
            cmd.Parameters.Add("@dtlanc", MySqlDbType.Int32).Value = jogo.dtlanc;
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = jogo.desc;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Jogo ListarCodJogo(int cod)
        {
            var comando = String.Format("select * from tbjogo where CodJogo={0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodJogo = cmd.ExecuteReader();
            return ListarCodJogo(DadosCodJogo).FirstOrDefault();
        }

        public List<Jogo> ListarCodJogo(MySqlDataReader dt) 
        {
            var AltJ = new List<Jogo>();
            while (dt.Read())
            {
                var AlTemp = new Jogo
                {
                    CodJogo = int.Parse(dt["CodJogo"].ToString()),
                    Nome = (dt["Nome"].ToString()),
                    versao = (dt["versao"].ToString()),
                    desenvolvedor = (dt["desenvolvedor"].ToString()),
                    genero = (dt["genero"].ToString()),
                    faixaetaria = int.Parse(dt["faixaetaria"].ToString()),
                    plataforma = (dt["plataforma"].ToString()),
                    dtlanc = int.Parse(dt["dtlanc"].ToString()),
                    desc = (dt["descricao"].ToString()),
                };
                AltJ.Add(AlTemp);
            }
            dt.Close();
            return AltJ;
        }

        public List<Jogo> ListarJogo()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbjogo", con.ConectarBD());
            var DadosJogo = cmd.ExecuteReader();
            return ListarTodosJogo(DadosJogo);

        }

        public List<Jogo> ListarTodosJogo(MySqlDataReader dt)
        {
            var TodosJogos = new List<Jogo>();
            while (dt.Read())
            {
                var JogoTemp = new Jogo()
                {
                    CodJogo = int.Parse(dt["CodJogo"].ToString()),
                    Nome = (dt["Nome"].ToString()),
                    versao = (dt["versao"].ToString()),
                    desenvolvedor = (dt["desenvolvedor"].ToString()),
                    genero = (dt["genero"].ToString()),
                    faixaetaria = int.Parse(dt["faixaetaria"].ToString()),
                    plataforma = (dt["plataforma"].ToString()),
                    dtlanc = int.Parse(dt["dtlanc"].ToString()),
                    desc = (dt["descricao"].ToString()),
                };
                TodosJogos.Add(JogoTemp);

            }
            dt.Close();
            return TodosJogos;
        }

        // FIM DO CADASTRO DE JOGOS


        // CADASTRO DO CLIENTE
        public void CadastrarCliente(Cliente cliente)
        {
            cmd = new MySqlCommand("insert into tbcliente values(@CliNome, @CliCPF, @CliDtNasc, @CliEmail, @CliCel, @CliEndereco)", con.ConectarBD());
            cmd.Parameters.Add("@CliNome", MySqlDbType.VarChar).Value = cliente.CliNome;
            cmd.Parameters.Add("@CliCPF", MySqlDbType.VarChar).Value = cliente.CliCPF;
            cmd.Parameters.Add("@CliDtNasc", MySqlDbType.Date).Value = cliente.CliDtNasc;
            cmd.Parameters.Add("@CliEmail", MySqlDbType.VarChar).Value = cliente.CliEmail;
            cmd.Parameters.Add("@CliCel", MySqlDbType.VarChar).Value = cliente.CliCel;
            cmd.Parameters.Add("@CliEndereco", MySqlDbType.VarChar).Value = cliente.CliEndereco;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Cliente ListarCodCli(int cod)
        {
            var comando = String.Format("select * from tbcliente where CPF={0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodCliente = cmd.ExecuteReader();
            return ListarCodCli(DadosCodCliente).FirstOrDefault();
        }

        public List<Cliente> ListarCodCli(MySqlDataReader dt)
        {
            var AltC = new List<Cliente>();
            while (dt.Read())
            {
                var AlTemp = new Cliente
                {
                    CliNome = (dt["CliNome"].ToString()),
                    CliCPF = (dt["CliCPF"].ToString()),
                    CliDtNasc = DateTime.Parse(dt["CliDtNasc"].ToString()),
                    CliEmail = (dt["CliEmail"].ToString()),
                    CliCel = (dt["CliCel"].ToString()),
                    CliEndereco = (dt["CliEndereco"].ToString()),
                };
                AltC.Add(AlTemp);
            }
            dt.Close();
            return AltC;
        }

        public List<Cliente> ListarCliente()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbcliente", con.ConectarBD());
            var DadosCli = cmd.ExecuteReader();
            return ListarTodosCli(DadosCli);

        }

        public List<Cliente> ListarTodosCli(MySqlDataReader dt)
        {
            var TodosCli = new List<Cliente>();
            while (dt.Read())
            {
                var CliTemp = new Cliente()
                {
                    CliNome = (dt["CliNome"].ToString()),
                    CliCPF = (dt["CliCPF"].ToString()),
                    CliDtNasc = DateTime.Parse(dt["CliDtNasc"].ToString()),
                    CliEmail = (dt["CliEmail"].ToString()),
                    CliCel = (dt["CliCel"].ToString()),
                    CliEndereco = (dt["CliEndereco"].ToString()),
                };
                TodosCli.Add(CliTemp);

            }
            dt.Close();
            return TodosCli;
        }

        //FIM DO CADASTRO E LISTAGEM DO CLIENTE

        // INICIO DO CADASTRO E LISTAGEM DO FUNCIONARIO
        public void CadastrarFunc(Funcionario funcionario)
        {
            cmd = new MySqlCommand("insert into tbfunc values(@CodFunc, @FuncNome, @FuncCPF, @FuncRG, @FuncDtNasc, @FuncEndereco, @FuncCel, @FuncEmail, @FuncCargo)", con.ConectarBD());
            cmd.Parameters.Add("@CodFunc", MySqlDbType.Int32).Value = funcionario.CodFunc;
            cmd.Parameters.Add("@FuncNome", MySqlDbType.VarChar).Value = funcionario.FuncNome;
            cmd.Parameters.Add("@FuncCPF", MySqlDbType.VarChar).Value = funcionario.FuncCPF;
            cmd.Parameters.Add("@FuncRG", MySqlDbType.VarChar).Value = funcionario.FuncRG;
            cmd.Parameters.Add("@FuncDtNasc", MySqlDbType.Date).Value = funcionario.FuncDtNasc;
            cmd.Parameters.Add("@FuncEndereco", MySqlDbType.VarChar).Value = funcionario.FuncEndereco;
            cmd.Parameters.Add("@FuncCel", MySqlDbType.VarChar).Value = funcionario.FuncCel;
            cmd.Parameters.Add("@FuncEmail", MySqlDbType.VarChar).Value = funcionario.FuncEmail;
            cmd.Parameters.Add("@FuncCargo", MySqlDbType.VarChar).Value = funcionario.FuncCargo;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Funcionario ListarCodFunc(int cod)
        {
            var comando = String.Format("select * from tbfunc where CodFunc={0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodFunc = cmd.ExecuteReader();
            return ListarCodFunc(DadosCodFunc).FirstOrDefault();
        }

        public List<Funcionario> ListarCodFunc(MySqlDataReader dt)
        {
            var AltF = new List<Funcionario>();
            while (dt.Read())
            {
                var AlTemp = new Funcionario
                {
                    CodFunc = ushort.Parse(dt["CodFunc"].ToString()),
                    FuncNome = (dt["FuncNome"].ToString()),
                    FuncCPF = (dt["FuncCPF"].ToString()),
                    FuncRG = (dt["FuncRG"].ToString()),
                    FuncDtNasc= DateTime.Parse(dt["FuncDtNasc"].ToString()),
                    FuncEndereco = (dt["FuncEndereco"].ToString()),
                    FuncCel = (dt["FuncCel"].ToString()),
                    FuncEmail = (dt["FuncEmail"].ToString()),
                    FuncCargo = (dt["FuncCargo"].ToString()),
                };
                AltF.Add(AlTemp);
            }
            dt.Close();
            return AltF;
        }

        public List<Funcionario> ListarFuncionario()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbfunc", con.ConectarBD());
            var DadosFunc = cmd.ExecuteReader();
            return ListarTodosFunc(DadosFunc);
        }

        public List<Funcionario> ListarTodosFunc(MySqlDataReader dt)
        {
            var TodosFunc = new List<Funcionario>();
            while (dt.Read())
            {
                var FuncTemp = new Funcionario()
                {
                    CodFunc = ushort.Parse(dt["CodFunc"].ToString()),
                    FuncNome = (dt["FuncNome"].ToString()),
                    FuncCPF = (dt["FuncCPF"].ToString()),
                    FuncRG = (dt["FuncRG"].ToString()),
                    FuncDtNasc = DateTime.Parse(dt["FuncDtNasc"].ToString()),
                    FuncEndereco = (dt["FuncEndereco"].ToString()),
                    FuncCel = (dt["FuncCel"].ToString()),
                    FuncEmail = (dt["FuncEmail"].ToString()),
                    FuncCargo = (dt["FuncCargo"].ToString()),
                };
                TodosFunc.Add(FuncTemp);

            }
            dt.Close();
            return TodosFunc;
        }
    }
}