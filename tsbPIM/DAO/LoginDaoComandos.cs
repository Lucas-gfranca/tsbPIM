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
                if (dr.HasRows)
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

        public void inserirVenda(int vendasId, String plano, DateTime dataVenda, String idCliente_vendas, String idSeguradora_vendas, String funcId_vendas)
        {

            try
            {
                cmd.Connection = con.conectar();
                //comandos sql para ver se tem no banco de dados
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "insertVendas";
                cmd.Parameters.AddWithValue("@vendasId", vendasId);
                cmd.Parameters.AddWithValue("@plano", plano);
                cmd.Parameters.AddWithValue("@dataVenda", dataVenda);
                cmd.Parameters.AddWithValue("@@idCliente_vendas", idCliente_vendas);
                cmd.Parameters.AddWithValue("@idSeguradora_vendas", idSeguradora_vendas);
                cmd.Parameters.AddWithValue("@funcId_vendas", funcId_vendas);

                cmd.ExecuteReader();
                MessageBox.Show("Venda realizada com Sucesso !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<FuncionarioModel> selecionarFunc()
        {
            List<FuncionarioModel> lstFuncionarios = new List<FuncionarioModel>();

            using (SqlCommand cmd = new SqlCommand("getFuncionario", con.conectar()))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            FuncionarioModel funcModel = new FuncionarioModel();
                            funcModel.funcId = (int)reader["funcId"];
                            funcModel.funcNome = (string)reader["funcNome"];
                            funcModel.cargo = (string)reader["cargo"];
                            funcModel.funcDataNasc = (DateTime)reader["funcDataNasc"];
                            funcModel.funcFone = (string)reader["funcFone"];
                            funcModel.funcSexo = (string)reader["funcSexo"];
                            funcModel.funcCpf = (string)reader["funcCpf"];
                            funcModel.funcEstCiv = (string)reader["funcEstCiv"];
                            funcModel.funcRg = (string)reader["funcRg"];
                            funcModel.funcCep = (string)reader["funcCep"];
                            funcModel.funcEmail = (string)reader["funcEmail"];
                            lstFuncionarios.Add(funcModel);
                        }
                    }
                }
            }
            return lstFuncionarios;
        }

        public List<SeguradoraModel> selecionarSeguradora()
        {
            List<SeguradoraModel> lstSeguradora = new List<SeguradoraModel>();

            using (SqlCommand cmd = new SqlCommand("getSeguradora", con.conectar()))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            SeguradoraModel segModel = new SeguradoraModel();
                            segModel.idSeguradora = (int)reader["idSeguradora"];
                            segModel.tipoServico = (string)reader["tipoServico"];
                            segModel.nomeSeguradora = (string)reader["nomeSeguradora"];
                            segModel.emailSeguradora = (string)reader["emailSeguradora"];
                            segModel.foneSeguradora = (string)reader["foneSeguradora"];
                            segModel.cnpjSeguradora = (string)reader["cnpjSeguradora"];
                            segModel.ruaSeguradora = (string)reader["ruaSeguradora"];
                            segModel.numSeguradora = (int)reader["numSeguradora"];
                            segModel.bairroSeguradora = (string)reader["bairroSeguradora"];
                            segModel.cidadeSeguradora = (string)reader["cidadeSeguradora"];
                            segModel.ufSeguradora = (string)reader["ufSeguradora"];
                            lstSeguradora.Add(segModel);
                        }
                    }
                }
            }
            return lstSeguradora;
        }


        public List<ClienteModel> selecionarCliente()
        {
            List<ClienteModel> lstClientes = new List<ClienteModel>();

            using (SqlCommand cmd = new SqlCommand("getClientes", con.conectar()))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            ClienteModel clienteModel = new ClienteModel();
                            clienteModel.idCliente = (int)reader["idCliente"];
                            clienteModel.clientePj = (Boolean)reader["clientePj"];
                            clienteModel.nomeCliente = (string)reader["nomeCliente"];
                            clienteModel.foneCliente = (string)reader["foneCliente"];
                            clienteModel.cpfCliente = (string)reader["cpfCliente"];
                            clienteModel.rgCliente = (string)reader["rgCliente"];
                            clienteModel.emailCliente = (string)reader["emailCliente"];
                            clienteModel.dataNascCliente = (DateTime)reader["dataNascCliente"];
                            clienteModel.sexoCliente = (string)reader["sexoCliente"];
                            clienteModel.estCivCliente = (string)reader["estCivCliente"];
                            clienteModel.peso = (double)reader["peso"];
                            clienteModel.altura = (double)reader["altura"];
                            clienteModel.fumante = (Boolean)reader["fumante"];
                            clienteModel.cirurgias = (Boolean)reader["cirurgias"];
                            clienteModel.doencas = (Boolean)reader["doencas"];
                            clienteModel.rua = (string)reader["rua"];
                            clienteModel.numero = (int)reader["numero"];
                            clienteModel.bairro = (string)reader["bairro"];
                            clienteModel.cidade = (string)reader["cidade"];
                            clienteModel.uf = (string)reader["uf"];
                            clienteModel.complemento = (string)reader["complemento"];
                            lstClientes.Add(clienteModel);
                        }
                    }
                }
            }
            return lstClientes;
        }





        public void cadFunc(int funcId, String funcNome, String cargo, DateTime funcDataNasc, String funcFone, String funcSexo, String funcCpf, String funcEstCiv, String funcRg, String funcCep, String funcEmail)
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
                cmd.Parameters.AddWithValue("@funcDataNasc", funcDataNasc);
                cmd.Parameters.AddWithValue("@funcFone", funcFone);
                cmd.Parameters.AddWithValue("@funcSexo", funcSexo);
                cmd.Parameters.AddWithValue("@funcCpf", funcCpf);
                cmd.Parameters.AddWithValue("@funcEstCiv", funcEstCiv);
                cmd.Parameters.AddWithValue("@funcRg", funcRg);
                cmd.Parameters.AddWithValue("@funcCep", funcCep);
                cmd.Parameters.AddWithValue("@funcEmail", funcEmail);

                cmd.ExecuteReader();
                MessageBox.Show("Funcionário cadastrado com Sucesso !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void alterarDadosFunc(int funcId, String funcNome, String cargo, DateTime funcDataNasc, String funcFone, String funcSexo, String funcCpf, String funcEstCiv, String funcRg, String funcCep, String funcEmail)
        {
            try
            {
                cmd.Connection = con.conectar();
                //comandos sql para ver se tem no banco de dados
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "atualizaDadosFuncionario";
                cmd.Parameters.AddWithValue("@funcId", funcId);
                cmd.Parameters.AddWithValue("@funcNome", funcNome);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@funcDataNasc", funcDataNasc);
                cmd.Parameters.AddWithValue("@funcFone", funcFone);
                cmd.Parameters.AddWithValue("@funcSexo", funcSexo);
                cmd.Parameters.AddWithValue("@funcCpf", funcCpf);
                cmd.Parameters.AddWithValue("@funcEstCiv", funcEstCiv);
                cmd.Parameters.AddWithValue("@funcRg", funcRg);
                cmd.Parameters.AddWithValue("@funcCep", funcCep);
                cmd.Parameters.AddWithValue("@funcEmail", funcEmail);

                cmd.ExecuteReader();
                MessageBox.Show("Dados atualizados com sucesso !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deletaDadosFunc(int funcId, String funcNome, String cargo, DateTime funcDataNasc, String funcFone, String funcSexo, String funcCpf, String funcEstCiv, String funcRg, String funcCep, String funcEmail)
        {
            try
            {
                cmd.Connection = con.conectar();
                //comandos sql para ver se tem no banco de dados
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "deletaDadosFuncionario";
                cmd.Parameters.AddWithValue("@funcId", funcId);
                cmd.Parameters.AddWithValue("@funcNome", funcNome);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@funcDataNasc", funcDataNasc);
                cmd.Parameters.AddWithValue("@funcFone", funcFone);
                cmd.Parameters.AddWithValue("@funcSexo", funcSexo);
                cmd.Parameters.AddWithValue("@funcCpf", funcCpf);
                cmd.Parameters.AddWithValue("@funcEstCiv", funcEstCiv);
                cmd.Parameters.AddWithValue("@funcRg", funcRg);
                cmd.Parameters.AddWithValue("@funcCep", funcCep);
                cmd.Parameters.AddWithValue("@funcEmail", funcEmail);

                cmd.ExecuteReader();
                MessageBox.Show("Funcionário excluido com Sucesso !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cadCliente(int idCliente, bool clientePj, String nomeCliente, String foneCliente, String cpfCliente, String rgCliente, String emailCliente, DateTime dataNascCliente, String sexoCliente, String estCivCliente, float altura, float peso, bool fumante, bool cirurgias, bool doencas, String rua, int numero, String bairro, String cidade, String uf, String complemento)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void alterarDadosCliente(int idCliente, bool clientePj, String nomeCliente, String foneCliente, String cpfCliente, String rgCliente, String emailCliente, DateTime dataNascCliente, String sexoCliente, String estCivCliente, float altura, float peso, bool fumante, bool cirurgias, bool doencas, String rua, int numero, String bairro, String cidade, String uf, String complemento)
        {
            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "atualizaCliente";
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
                MessageBox.Show("Dados atualizados com sucesso !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deletaClientes(int idCliente, bool clientePj, String nomeCliente, String foneCliente, String cpfCliente, String rgCliente, String emailCliente, DateTime dataNascCliente, String sexoCliente, String estCivCliente, float altura, float peso, bool fumante, bool cirurgias, bool doencas, String rua, int numero, String bairro, String cidade, String uf, String complemento)
        {
            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "deletaCliente";
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
                MessageBox.Show("Cliente deletado com sucesso !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dependentes(String nomeDependente, String sexoDependente, String cpfDependente, String emailDependente)
        {
            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "InserirDadosDependentes";
                cmd.Parameters.AddWithValue("@nomeDependente", nomeDependente);
                cmd.Parameters.AddWithValue("@sexoDependente", sexoDependente);
                cmd.Parameters.AddWithValue("@cpfDependente", cpfDependente);
                cmd.Parameters.AddWithValue("@emailDependente", emailDependente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cadSeguradadora(int idSeguradora, String tipoServico, String nomeSeguradora, String emailSeguradora, String foneSeguradora, String cnpjSeguradora, String ruaSeguradora, int numSeguradora, String bairroSeguradora, String cidadeSeguradora, String ufSeguradora, String complementoSeguradora)
        {
            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "cadastrarSeguradora";
                cmd.Parameters.AddWithValue("@idSeguradora", idSeguradora);
                cmd.Parameters.AddWithValue("@tipoServico", tipoServico);
                cmd.Parameters.AddWithValue("@nomeSeguradora", nomeSeguradora);
                cmd.Parameters.AddWithValue("@emailSeguradora", emailSeguradora);
                cmd.Parameters.AddWithValue("@foneSeguradora", foneSeguradora);
                cmd.Parameters.AddWithValue("@cnpjSeguradora", cnpjSeguradora);
                cmd.Parameters.AddWithValue("@ruaSeguradora", ruaSeguradora);
                cmd.Parameters.AddWithValue("@numSeguradora", numSeguradora);
                cmd.Parameters.AddWithValue("@bairroSeguradora", bairroSeguradora);
                cmd.Parameters.AddWithValue("@cidadeSeguradora", cidadeSeguradora);
                cmd.Parameters.AddWithValue("@ufSeguradora", ufSeguradora);
                cmd.Parameters.AddWithValue("@complementoSeguradora", complementoSeguradora);

                cmd.ExecuteReader();
                MessageBox.Show("Seguradora cadastrada com sucesso !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void alterarDadosSeguradadora(int idSeguradora, String tipoServico, String nomeSeguradora, String emailSeguradora, String foneSeguradora, String cnpjSeguradora, String ruaSeguradora, int numSeguradora, String bairroSeguradora, String cidadeSeguradora, String ufSeguradora, String complementoSeguradora)
        {
            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "atualizaDadosSeguradora";
                cmd.Parameters.AddWithValue("@idSeguradora", idSeguradora);
                cmd.Parameters.AddWithValue("@tipoServico", tipoServico);
                cmd.Parameters.AddWithValue("@nomeSeguradora", nomeSeguradora);
                cmd.Parameters.AddWithValue("@emailSeguradora", emailSeguradora);
                cmd.Parameters.AddWithValue("@foneSeguradora", foneSeguradora);
                cmd.Parameters.AddWithValue("@cnpjSeguradora", cnpjSeguradora);
                cmd.Parameters.AddWithValue("@ruaSeguradora", ruaSeguradora);
                cmd.Parameters.AddWithValue("@numSeguradora", numSeguradora);
                cmd.Parameters.AddWithValue("@bairroSeguradora", bairroSeguradora);
                cmd.Parameters.AddWithValue("@cidadeSeguradora", cidadeSeguradora);
                cmd.Parameters.AddWithValue("@ufSeguradora", ufSeguradora);
                cmd.Parameters.AddWithValue("@complementoSeguradora", complementoSeguradora);

                cmd.ExecuteReader();
                MessageBox.Show("Seguradora atualizada com sucesso !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deletaDadosSeguradadora(int idSeguradora, String tipoServico, String nomeSeguradora, String emailSeguradora, String foneSeguradora, String cnpjSeguradora, String ruaSeguradora, int numSeguradora, String bairroSeguradora, String cidadeSeguradora, String ufSeguradora, String complementoSeguradora)
        {
            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "deletaSeguradora";
                cmd.Parameters.AddWithValue("@idSeguradora", idSeguradora);
                cmd.Parameters.AddWithValue("@tipoServico", tipoServico);
                cmd.Parameters.AddWithValue("@nomeSeguradora", nomeSeguradora);
                cmd.Parameters.AddWithValue("@emailSeguradora", emailSeguradora);
                cmd.Parameters.AddWithValue("@foneSeguradora", foneSeguradora);
                cmd.Parameters.AddWithValue("@cnpjSeguradora", cnpjSeguradora);
                cmd.Parameters.AddWithValue("@ruaSeguradora", ruaSeguradora);
                cmd.Parameters.AddWithValue("@numSeguradora", numSeguradora);
                cmd.Parameters.AddWithValue("@bairroSeguradora", bairroSeguradora);
                cmd.Parameters.AddWithValue("@cidadeSeguradora", cidadeSeguradora);
                cmd.Parameters.AddWithValue("@ufSeguradora", ufSeguradora);
                cmd.Parameters.AddWithValue("@complementoSeguradora", complementoSeguradora);

                cmd.ExecuteReader();
                MessageBox.Show("Seguradora deletada com sucesso !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
