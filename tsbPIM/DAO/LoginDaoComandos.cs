using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tsbPIM.Modelo;


//namespace tsbPIM.Apresentação;

namespace tsbPIM.DAL
{
     public class LoginDaoComandos
    {
        public bool temAdm = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String emailAdm, String senhaAdm)
        {
            cmd.Connection = con.conectar();
            //comandos sql para ver se tem no banco de dados
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "getDadosAdm";
            cmd.Parameters.AddWithValue("@emailAdm", emailAdm);
            cmd.Parameters.AddWithValue("@senhaAdm", senhaAdm);

            try
            {
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    temAdm = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco de Dados !";
            }
            return temAdm;
        }
        public void cadFunc(int funcId, String funcNome, String cargo, String funcFone, String funcSexo, String funcCpf, String funcEstCiv, String funcRg, String funcCep, String funcEmail)
        {
            
            try
            {
                cmd.Connection = con.conectar();
                //comandos sql para ver se tem no banco de dados
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "InsertDadosFuncionario";
                cmd.Parameters.AddWithValue("@funcId", funcId);
                cmd.Parameters.AddWithValue("@funcNome", funcNome);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@funcFone", funcFone);
                cmd.Parameters.AddWithValue("@funcSexo", funcSexo);
                cmd.Parameters.AddWithValue("@funcCpf", funcCpf);
                cmd.Parameters.AddWithValue("@funcEstCiv", funcEstCiv);
                cmd.Parameters.AddWithValue("@funcRg", funcRg);
                cmd.Parameters.AddWithValue("@funcCep", funcCep);
                cmd.Parameters.AddWithValue("@funcEmail", funcEmail);

                cmd.ExecuteReader();

                //cmd.CommandText = "insert into funcionario where funcId = " + funcId + "cargo" + cargo + "funcFone" + funcFone + "funcSexo" + funcSexo + "funcCpf" + funcCpf + "funcEstCiv" + funcEstCiv + "funcRg" + funcRg + "funcCep" + funcCep + "funcEmail" + funcEmail;
                MessageBox.Show("Funcionário cadastrado com Sucesso !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cadCliente(int idCliente, bool clientePj, String nomeCliente, String foneCliente, String cpfCliente, String rgCliente, String emailCliente, String dataNascCliente, String sexoCliente, String estCivCliente, float altura, float peso, bool fumante, bool cirurgias, bool doencas, String rua, int numero, String bairro, String cidade, String uf, String complemento )
        {
            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "InserirDadosCliente";
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                cmd.Parameters.AddWithValue("@clientePj", clientePj);
                cmd.Parameters.AddWithValue("@nomeCliente", nomeCliente);
                cmd.Parameters.AddWithValue("@foneCliente", foneCliente);
                cmd.Parameters.AddWithValue("@cpfCliente", cpfCliente);
                cmd.Parameters.AddWithValue("@rgCliente", rgCliente);
                cmd.Parameters.AddWithValue("@emailCliente", emailCliente);
                cmd.Parameters.AddWithValue("@dataNascCliente", dataNascCliente);
                cmd.Parameters.AddWithValue("@sexoCliente", sexoCliente);
                cmd.Parameters.AddWithValue("@estCivCliente", estCivCliente);
                cmd.Parameters.AddWithValue("@altura", altura);
                cmd.Parameters.AddWithValue("@peso", peso);
                cmd.Parameters.AddWithValue("@fumante", fumante);
                cmd.Parameters.AddWithValue("@cirurgias", cirurgias);
                cmd.Parameters.AddWithValue("@doencas", doencas);
                cmd.Parameters.AddWithValue("@rua", rua);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@uf", uf);
                cmd.Parameters.AddWithValue("@complemento", complemento);

                cmd.ExecuteReader();
                MessageBox.Show("Cliente cadastrado com sucesso !!!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        public void dependentes(String nomeDependente, String sexoDependente, String cpfDependente, String emailDependente)
        {
            cmd.Connection = con.conectar();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "InserirDadosDependentes";
            cmd.Parameters.AddWithValue("@nomeDependente", nomeDependente);
            cmd.Parameters.AddWithValue("@sexoDependente", sexoDependente);
            cmd.Parameters.AddWithValue("@cpfDependente", cpfDependente);
            cmd.Parameters.AddWithValue("@emailDependente", emailDependente);

            cmd.ExecuteReader();
        }


    }

    
}
