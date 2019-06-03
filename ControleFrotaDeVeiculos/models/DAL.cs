using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ControleFrotaDeVeiculos.models
{
    class DAL
    {
        public string _conexaoMySQL = "";
        MySqlConnection con = null;
        

        public DAL ()
        {
            _conexaoMySQL = "server=localhost;user id=root;password=123456;database=frota";
        }

        //Veículos

        //Retorna um DataTable com todos os veículos.
        public DataTable SelectVeiculos()
        {
            try
            {
                String sql = "SELECT * FROM veiculos";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna um veículo buscando pela placa
        public Veiculos selectVeiculosByPlaca(string placa)
        {
            try
            {
                String sql = "SELECT * FROM veiculos WHERE placa = @placa";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("placa", placa);
                con.Open();
                MySqlDataReader dr;
                Veiculos veiculos = new Veiculos();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    veiculos.Placa = dr["placa"].ToString();
                    veiculos.Marca = dr["marca"].ToString();
                    veiculos.Modelo = dr["modelo"].ToString();
                    veiculos.Cor = dr["cor"].ToString();
                    veiculos.AnoMod = dr["ano_modelo"].ToString();
                    veiculos.AnoFabr = dr["ano_fabricacao"].ToString();
                    veiculos.Kilometragem = dr["km_atual"].ToString();
                    veiculos.Situacao = dr["situacao"].ToString();
                    veiculos.Motorista = dr["motorista"].ToString();
                    veiculos.Combustivel = dr["combustivel"].ToString();
                    veiculos.Renavam = dr["renavam"].ToString();
                    veiculos.Chassi = dr["chassi"].ToString();
                    veiculos.Motorizacao = dr["motorizacao"].ToString();
                    veiculos.Tipo = dr["tipo"].ToString();
                }
                return veiculos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Insere um novo veículo
        public void InsertVeiculo(Veiculos veiculos)
        {
            try
            {
                String sql = "INSERT INTO veiculos(placa, marca, modelo, cor, ano_fabricacao, ano_modelo, km_atual, combustivel, renavam, chassi, motorizacao, tipo, motorista,situacao) VALUES (@placa, @marca, @modelo, @cor, @ano_fabricacao, @ano_modelo, @km_atual, @combustivel, @renavam, @chassi, @motorizacao, @tipo, @motorista,@situacao)";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@placa", veiculos.Placa);
                cmd.Parameters.AddWithValue("@marca", veiculos.Marca);
                cmd.Parameters.AddWithValue("@modelo", veiculos.Modelo);
                cmd.Parameters.AddWithValue("@cor", veiculos.Cor);
                cmd.Parameters.AddWithValue("@ano_fabricacao", veiculos.AnoFabr);
                cmd.Parameters.AddWithValue("@ano_modelo", veiculos.AnoMod);
                cmd.Parameters.AddWithValue("@km_atual", veiculos.Kilometragem);
                cmd.Parameters.AddWithValue("@combustivel", veiculos.Combustivel);
                cmd.Parameters.AddWithValue("@renavam", veiculos.Renavam);
                cmd.Parameters.AddWithValue("@chassi", veiculos.Chassi);
                cmd.Parameters.AddWithValue("@motorizacao", veiculos.Motorizacao);
                cmd.Parameters.AddWithValue("@tipo", veiculos.Tipo);
                cmd.Parameters.AddWithValue("@motorista", veiculos.Motorista);
                cmd.Parameters.AddWithValue("@situacao", veiculos.Situacao);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Retorna uma lista com os últimos veículos adicionados  
        public List <Veiculos> selectListUltVeiculos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_conexaoMySQL))
                {
                    using (MySqlCommand command = new MySqlCommand("Select placa, marca, modelo, cor from veiculos order by id desc limit 8", conn))
                    {
                        conn.Open();
                        List<Veiculos> listaVeiculos = new List<Veiculos>();
                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {              
                                Veiculos veiculos = new Veiculos();
                                veiculos.Placa = (String)dr["placa"];
                                veiculos.Marca = (String)dr["marca"];
                                veiculos.Modelo = (String)dr["modelo"];
                                veiculos.Cor = (String)dr["cor"];
                                listaVeiculos.Add(veiculos);
                            }
                        }
                        return listaVeiculos;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar lista " + ex.Message);
            }
        }

        //Retorna uma lista com todos os veículos
        public List<Veiculos> selectListAllVeiculos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_conexaoMySQL))
                {
                    using (MySqlCommand command = new MySqlCommand("Select placa, marca, modelo, cor from veiculos", conn))
                    {
                        conn.Open();
                        List<Veiculos> listaVeiculos = new List<Veiculos>();
                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Veiculos veiculos = new Veiculos();
                                veiculos.Placa = (String)dr["placa"];
                                veiculos.Marca = (String)dr["marca"];
                                veiculos.Modelo = (String)dr["modelo"];
                                veiculos.Cor = (String)dr["cor"];
                                listaVeiculos.Add(veiculos);
                            }
                        }
                        return listaVeiculos;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar lista " + ex.Message);
            }
        }

        //Retorna um AutoComplete com todas as placas
        public AutoCompleteStringCollection AutoCompletePlaca()
        {
            String sql = "SELECT placa FROM veiculos";
            con = new MySqlConnection(_conexaoMySQL);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader dr;
            AutoCompleteStringCollection placasCollection = new AutoCompleteStringCollection();
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                placasCollection.Add(dr["placa"].ToString());
            }
            return placasCollection;
        }

        //Faz o Update de um veículo
        public void UpdateVeiculo(Veiculos veiculos)
        {
            try
            {
                String sql = "UPDATE veiculos SET placa=@placa, marca=@marca, modelo=@modelo, cor=@cor, ano_fabricacao=@ano_fabricacao, ano_modelo=@ano_modelo, km_atual=@km_atual, combustivel=@combustivel, renavam=@renavam, chassi=@chassi, motorizacao=@motorizacao, tipo=@tipo, motorista=@motorista, situacao=@situacao WHERE placa=@placa";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@placa", veiculos.Placa);
                cmd.Parameters.AddWithValue("@marca", veiculos.Marca);
                cmd.Parameters.AddWithValue("@modelo", veiculos.Modelo);
                cmd.Parameters.AddWithValue("@cor", veiculos.Cor);
                cmd.Parameters.AddWithValue("@ano_fabricacao", veiculos.AnoFabr);
                cmd.Parameters.AddWithValue("@ano_modelo", veiculos.AnoMod);
                cmd.Parameters.AddWithValue("@km_atual", veiculos.Kilometragem);
                cmd.Parameters.AddWithValue("@combustivel", veiculos.Combustivel);
                cmd.Parameters.AddWithValue("@renavam", veiculos.Renavam);
                cmd.Parameters.AddWithValue("@chassi", veiculos.Chassi);
                cmd.Parameters.AddWithValue("@motorizacao", veiculos.Motorizacao);
                cmd.Parameters.AddWithValue("@tipo", veiculos.Tipo);
                cmd.Parameters.AddWithValue("@motorista", veiculos.Motorista);
                cmd.Parameters.AddWithValue("@situacao", veiculos.Situacao);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Deleta um veículo
        public void DeleteVeiculo(Veiculos veiculos)
        {
            try
            {
                String sql = "DELETE FROM veiculos WHERE placa=@placa";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@placa", veiculos.Placa);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        //Motoristas

        //Insere um novo motorista
        public void InsertMotorista(Motorista motorista)
        {
            try
            {
                String sql = "INSERT INTO motorista(nome,cpf,rg,dtnascimento,cnh,valcnh,rua,cidade,bairro,numero,cep,telresidencial,telcelular) VALUES (@nome,@cpf,@rg,@dtnascimento,@cnh,@valcnh,@rua,@cidade,@bairro,@numero,@cep,@telresidencial,@telcelular)";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", motorista.Nome);
                cmd.Parameters.AddWithValue("@cpf", motorista.CPF);
                cmd.Parameters.AddWithValue("@rg", motorista.RG);
                cmd.Parameters.AddWithValue("@cnh", motorista.NCNH);
                cmd.Parameters.AddWithValue("@valcnh", motorista.ValCNH);
                cmd.Parameters.AddWithValue("@dtnascimento", motorista.DtNascimento);
                cmd.Parameters.AddWithValue("@rua", motorista.Rua);
                cmd.Parameters.AddWithValue("@cidade", motorista.Cidade);
                cmd.Parameters.AddWithValue("@bairro", motorista.Bairro);
                cmd.Parameters.AddWithValue("@cep", motorista.CEP);
                cmd.Parameters.AddWithValue("@numero", motorista.Numero);
                cmd.Parameters.AddWithValue("@telresidencial", motorista.Telefone);
                cmd.Parameters.AddWithValue("@telcelular", motorista.Celular);
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna uma lista com os últimos motoristas
        public List<Motorista> selectListUltMotoristas()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_conexaoMySQL))
                {
                    using (MySqlCommand command = new MySqlCommand("Select nome, cpf, cnh, valcnh from motorista order by id desc limit 8", conn))
                    {
                        conn.Open();
                        List<Motorista> listaMotorista = new List<Motorista>();
                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Motorista motorista = new Motorista();
                                motorista.Nome = (String)dr["nome"];
                                motorista.CPF = (String)dr["cpf"];
                                motorista.NCNH = (String)dr["cnh"];
                                motorista.ValCNH = (String)dr["valcnh"];                            
                                listaMotorista.Add(motorista);
                            }
                        }
                        return listaMotorista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar lista " + ex.Message);
            }
        }

        //Retorna uma lista com todos os motoristas
        public List<Motorista> selectListAllMotoristas()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_conexaoMySQL))
                {
                    using (MySqlCommand command = new MySqlCommand("Select nome, cpf, cnh, valcnh from motorista", conn))
                    {
                        conn.Open();
                        List<Motorista> listaMotorista = new List<Motorista>();
                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Motorista motorista = new Motorista();
                                motorista.Nome = (String)dr["nome"];
                                motorista.CPF = (String)dr["cpf"];
                                motorista.NCNH = (String)dr["cnh"];
                                motorista.ValCNH = (String)dr["valcnh"];
                                listaMotorista.Add(motorista);
                            }
                        }
                        return listaMotorista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar lista " + ex.Message);
            }
        }

        //Retorna um motorista buscando pelo CPF
        public Motorista SelectMotoristaByCPF(string cpf)
        {
            try
            {
                String sql = "SELECT * FROM motorista WHERE cpf = @cpf";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                con.Open();
                MySqlDataReader dr;
                Motorista motorista = new Motorista();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    motorista.Nome = dr["nome"].ToString();
                    motorista.CPF = dr["cpf"].ToString();
                    motorista.RG = dr["rg"].ToString();
                    motorista.NCNH = dr["cnh"].ToString();
                    motorista.ValCNH = dr["valcnh"].ToString();
                    motorista.DtNascimento = dr["dtnascimento"].ToString();
                    motorista.Rua = dr["rua"].ToString();
                    motorista.Cidade = dr["cidade"].ToString();
                    motorista.Bairro = dr["bairro"].ToString();
                    motorista.Numero = dr["numero"].ToString();
                    motorista.CEP = dr["cep"].ToString();
                    motorista.Telefone = dr["telresidencial"].ToString();
                    motorista.Celular = dr["telcelular"].ToString();
                }
                return motorista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna um motorista buscando pelo nome
        public Motorista SelectMotoristaByNome(string nome)
        {
            try
            {
                String sql = "SELECT * FROM motorista WHERE nome = @nome";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", nome);
                con.Open();
                MySqlDataReader dr;
                Motorista motorista = new Motorista();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    motorista.Nome = dr["nome"].ToString();
                    motorista.CPF = dr["cpf"].ToString();
                    motorista.RG = dr["rg"].ToString();
                    motorista.NCNH = dr["cnh"].ToString();
                    motorista.ValCNH = dr["valcnh"].ToString();
                    motorista.DtNascimento = dr["dtnascimento"].ToString();
                    motorista.Rua = dr["rua"].ToString();
                    motorista.Cidade = dr["cidade"].ToString();
                    motorista.Bairro = dr["bairro"].ToString();
                    motorista.Numero = dr["numero"].ToString();
                    motorista.CEP = dr["cep"].ToString();
                    motorista.Telefone = dr["telresidencial"].ToString();
                    motorista.Celular = dr["telcelular"].ToString();
                }
                return motorista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna um DataTable com todos os motoristas
        public DataTable selectNomeMotoristas()
        {
            try
            {
                String sql = "SELECT * FROM motorista";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna um AutoComplete com todos os nomes dos motoristas
        public AutoCompleteStringCollection AutoCompleteName ()
        {
            String sql = "SELECT nome FROM motorista";
            con = new MySqlConnection(_conexaoMySQL);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader dr;
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while(dr.Read())
            {
                namesCollection.Add(dr["nome"].ToString());
            }
            return namesCollection;
        }

        //Retorna um AutoComplete com todos os CPF's
        public AutoCompleteStringCollection AutoCompleteCPF()
        {
            String sql = "SELECT cpf FROM motorista";
            con = new MySqlConnection(_conexaoMySQL);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader dr;
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                namesCollection.Add(dr["cpf"].ToString());
            }
            return namesCollection;
        }

        //Faz o Update do motorista
        public void UpdateMotorista(Motorista motorista)
        {
            try
            {
                String sql = "UPDATE motorista SET nome=@nome, dtnascimento=@dtnascimento, cpf=@cpf, rg=@rg, cnh=@cnh, valcnh=@valcnh, rua=@rua, cidade=@cidade, bairro=@bairro, numero=@numero, cep=@cep, telresidencial=@telresidencial, telcelular=@telcelular WHERE cpf=@cpf";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", motorista.Nome);
                cmd.Parameters.AddWithValue("@dtnascimento", motorista.DtNascimento);
                cmd.Parameters.AddWithValue("@cpf", motorista.CPF);
                cmd.Parameters.AddWithValue("@rg", motorista.RG);
                cmd.Parameters.AddWithValue("@cnh", motorista.NCNH);
                cmd.Parameters.AddWithValue("@valcnh", motorista.ValCNH);
                cmd.Parameters.AddWithValue("@rua", motorista.Rua);
                cmd.Parameters.AddWithValue("@cidade", motorista.Cidade);
                cmd.Parameters.AddWithValue("@bairro", motorista.Bairro);
                cmd.Parameters.AddWithValue("@numero", motorista.Numero);
                cmd.Parameters.AddWithValue("@cep", motorista.CEP);
                cmd.Parameters.AddWithValue("@telresidencial", motorista.Telefone);
                cmd.Parameters.AddWithValue("@telcelular", motorista.Celular);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Deleta um Motorista
        public void DeleteMotorista(Motorista motorista)
        {
            try
            {
                String sql = "DELETE FROM motorista WHERE cpf=@cpf";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cpf", motorista.CPF);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Viagens



        //Insere uma nova viagem
        public void InsertViagem(Viagens viagens)
        {
            try
            {
                String sql = "INSERT INTO viagens(cpfmotorista, nomemotorista, placacarro, dateviagem, dateviagemfeita, motivo, situacao, kminicial, kmfinal) VALUES (@cpfmotorista, @nomemotorista, @placacarro, @dateviagem, @dateviagemfeita, @motivo, @situacao, @kminicial, @kmfinal)";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cpfmotorista", viagens.Motorista.CPF);
                cmd.Parameters.AddWithValue("@nomemotorista", viagens.Motorista.Nome);
                cmd.Parameters.AddWithValue("@placacarro", viagens.Veiculos.Placa);
                cmd.Parameters.AddWithValue("@dateviagem", viagens.dateViagem);
                cmd.Parameters.AddWithValue("@dateviagemfeita", viagens.dateViagemFeita);
                cmd.Parameters.AddWithValue("@motivo", viagens.Motivo);
                cmd.Parameters.AddWithValue("@situacao", viagens.Situacao);
                cmd.Parameters.AddWithValue("@kminicial", viagens.KmInicial);
                cmd.Parameters.AddWithValue("@kmfinal", viagens.KmFinal);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Faz o update de uma viagem
        public void UpdateViagem(Viagens viagens)
        {
            try
            {
                String sql = "UPDATE viagens SET dateviagem=@dateviagem, nomemotorista=@nomemotorista, placacarro=@placacarro, dateviagemfeita=@dateviagemfeita, motivo=@motivo, situacao=@situacao, kminicial=@kminicial, kmfinal=@kmfinal WHERE id=@id";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", viagens.ID);
                cmd.Parameters.AddWithValue("@dateviagem", viagens.dateViagem);
                cmd.Parameters.AddWithValue("@nomemotorista", viagens.Motorista.Nome);
                cmd.Parameters.AddWithValue("@placacarro", viagens.Veiculos.Placa);
                cmd.Parameters.AddWithValue("@dateviagemfeita", viagens.dateViagemFeita);
                cmd.Parameters.AddWithValue("@motivo", viagens.Motivo);
                cmd.Parameters.AddWithValue("@situacao", viagens.Situacao);
                cmd.Parameters.AddWithValue("@kminicial", viagens.KmInicial);
                cmd.Parameters.AddWithValue("@kmfinal", viagens.KmFinal);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Deleta uma viagem
        public void DeleteViagem(Viagens viagens)
        {
            try
            {
                String sql = "DELETE FROM viagens WHERE id=@id";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", viagens.ID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna uma viagem pelo ID
        public Viagens SelectViagemByID(int id)
        {
            try
            {
                String sql = "SELECT * FROM viagens WHERE id = @id";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                MySqlDataReader dr;
                Viagens viagens = new Viagens();
                Motorista motorista = new Motorista();
                Veiculos veiculos = new Veiculos();
                viagens.Motorista = motorista;
                viagens.Veiculos = veiculos;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    viagens.dateViagem = Convert.ToDateTime(dr["dateviagem"]);
                    viagens.dateViagemFeita = Convert.ToDateTime(dr["dateviagemfeita"]);
                    viagens.KmInicial = dr["kminicial"].ToString();
                    viagens.KmFinal = dr["kmfinal"].ToString();
                    viagens.Motorista.Nome = dr["nomemotorista"].ToString();
                    viagens.Veiculos.Placa = dr["placacarro"].ToString();
                    viagens.Motivo = dr["motivo"].ToString();
                    viagens.Situacao = dr["situacao"].ToString();
                }
                return viagens;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna uma lista com todos os tipos de viagens
        public List<Viagens> ListaViagens(string comando, string dia,  string mes, string ano, string nomemotorista, string placa)
        {
            try
            {
                String sql = "";

                if (comando == "Todos" || comando == "Mot" || comando == "Placa")
                {
                    if (comando == "Todos")
                    {
                        sql = "SELECT * FROM viagens ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "Mot")
                    {
                        sql = "SELECT * FROM viagens WHERE nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "Placa")
                    {
                        sql = "SELECT * FROM viagens WHERE placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDia" || comando == "MotDia" || comando == "PlacaDia")
                {
                    if (comando == "TodosDia")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotDia")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaDia")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosMes" || comando == "MotMes" || comando == "PlacaMes")
                {
                    if (comando == "TodosMes")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotMes")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaMes")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosAno" || comando == "MotAno" || comando == "PlacaAno")
                {
                    if (comando == "TodosAno")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotAno")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaAno")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosPend" || comando == "MotPend" || comando == "PlacaPend")
                {
                    if (comando == "TodosPend")
                    {
                        sql = "SELECT * FROM viagens WHERE situacao ='Pendente' ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotPend")
                    {
                        sql = "SELECT * FROM viagens WHERE situacao ='Pendente' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaPend")
                    {
                        sql = "SELECT * FROM viagens WHERE situacao ='Pendente' AND placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosConc" || comando == "MotConc" || comando == "PlacaConc")
                {
                    if (comando == "TodosConc")
                    {
                        sql = "SELECT * FROM viagens WHERE situacao = 'Realizada' ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotConc")
                    {
                        sql = "SELECT * FROM viagens WHERE situacao = 'Realizada' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaConc")
                    {
                        sql = "SELECT * FROM viagens WHERE situacao = 'Realizada' AND placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaMes" || comando == "MotDiaMes" || comando == "PlacaDiaMes")
                {
                    if (comando == "TodosDiaMes")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND MONTH(dateviagem) = @mes ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotDiaMes")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND MONTH(dateviagem) = @mes AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaMes")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND MONTH(dateviagem) = @mes AND placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaAno" || comando == "MotDiaAno" || comando == "PlacaDiaAno")
                {
                    if (comando == "TodosDiaAno")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND YEAR(dateviagem) = @ano ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotDiaAno")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND YEAR(dateviagem) = @ano AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaAno")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND YEAR(dateviagem) = @ano AND placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaPend" || comando == "MotDiaPend" || comando == "PlacaDiaPend")
                {
                    if (comando == "TodosDiaPend")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND situacao = 'Pendente' ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotDiaPend")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND situacao = 'Pendente' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaPend")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND situacao = 'Pendente' AND placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaConc" || comando == "MotDiaConc" || comando == "PlacaDiaConc")
                {
                    if (comando == "TodosDiaConc")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND situacao = 'Realizada' ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotDiaConc")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND situacao = 'Realizada' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaConc")
                    {
                        sql = "SELECT * FROM viagens WHERE DAY(dateviagem) = @dia AND situacao = 'Realizada' AND placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosMesAno" || comando == "MotMesAno" || comando == "PlacaMesAno")
                {
                    if (comando == "TodosMesAno")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND YEAR(dateviagem) = @ano ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotMesAno")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND YEAR(dateviagem) = @ano AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaMesAno")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND YEAR(dateviagem) = @ano AND placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosMesPend" || comando == "MotMesPend" || comando == "PlacaMesPend")
                {
                    if (comando == "TodosMesPend")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND situacao = 'Pendente' ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotMesPend")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND situacao = 'Pendente' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaMesPend")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND situacao = 'Pendente' AND placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosMesConc" || comando == "MotMesConc" || comando == "PlacaMesConc")
                {
                    if (comando == "TodosMesConc")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND situacao = 'Realizada'  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotMesConc")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND situacao = 'Realizada' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaMesConc")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND situacao = 'Realizada' AND placacarro=@placa  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }

                }
                else if (comando == "TodosAnoPend" || comando == "MotAnoPend" || comando == "PlacaAnoPend")
                {
                    if (comando == "TodosAnoPend")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND situacao = 'Pendente' ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotAnoPend")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND situacao = 'Pendente' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaAnoPend")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND situacao = 'Pendente' AND placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosAnoConc" || comando == "MotAnoConc" || comando == "PlacaAnoConc")
                {
                    if (comando == "TodosAnoConc")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND situacao = 'Realizada' ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotAnoConc")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND situacao = 'Realizada' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaAnoConc")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND situacao = 'Realizada' AND placacarro=@placa ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosMesAnoPend" || comando == "MotMesAnoPend" || comando == "PlacaMesAnoPend")
                {
                    if (comando == "TodosMesAnoPend")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND YEAR(dateviagem) = @ano AND situacao = 'Pendente'  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotMesAnoPend")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND YEAR(dateviagem) = @ano AND situacao = 'Pendente' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaMesAnoPend")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND YEAR(dateviagem) = @ano AND situacao = 'Pendente' AND placacarro=@placa  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosMesAnoConc" || comando == "MotMesAnoConc" || comando == "PlacaMesAnoConc")
                {
                    if (comando == "TodosMesAnoConc")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND YEAR(dateviagem) = @ano AND situacao = 'Realizada'  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotMesAnoConc")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND YEAR(dateviagem) = @ano AND situacao = 'Realizada' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaMesAnoConc")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND YEAR(dateviagem) = @ano AND situacao = 'Realizada' AND placacarro=@placa  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaMesPend" || comando == "MotDiaMesPend" || comando == "PlacaDiaMesPend")
                {
                    if (comando == "TodosDiaMesPend")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND situacao = 'Pendente'  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotDiaMesPend")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND situacao = 'Pendente' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaMesPend")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND situacao = 'Pendente' AND placacarro=@placa  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaMesConc" || comando == "MotDiaMesConc" || comando == "PlacaDiaMesConc")
                {
                    if (comando == "TodosDiaMesConc")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND situacao = 'Realizada'  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotDiaMesConc")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND situacao = 'Realizada' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaMesConc")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND situacao = 'Realizada' AND placacarro=@placa  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaAnoPend" || comando == "MotDiaAnoPend" || comando == "PlacaDiaAnoPend")
                {
                    if (comando == "TodosDiaAnoPend")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND DAY(dateviagem) = @dia AND situacao = 'Pendente'  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotDiaAnoPend")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND DAY(dateviagem) = @dia AND situacao = 'Pendente' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaAnoPend")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND DAY(dateviagem) = @dia AND situacao = 'Pendente' AND placacarro=@placa  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaAnoConc" || comando == "MotDiaAnoConc" || comando == "PlacaDiaAnoConc")
                {
                    if (comando == "TodosDiaAnoConc")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND DAY(dateviagem) = @dia AND situacao = 'Realizada'  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotDiaAnoConc")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND DAY(dateviagem) = @dia AND situacao = 'Realizada' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaAnoConc")
                    {
                        sql = "SELECT * FROM viagens WHERE YEAR(dateviagem) = @ano AND DAY(dateviagem) = @dia AND situacao = 'Realizada' AND placacarro=@placa  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaMesAno" || comando == "MotDiaMesAno" || comando == "PlacaDiaMesAno")
                {
                    if (comando == "TodosDiaMesAno")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND YEAR(dateviagem) = @ano  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotDiaMesAno")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND YEAR(dateviagem) = @ano AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaMesAno")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND YEAR(dateviagem) = @ano AND placacarro=@placa  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaMesAnoPend" || comando == "MotDiaMesAnoPend" || comando == "PlacaDiaMesAnoPend")
                {
                    if (comando == "TodosDiaMesAnoPend")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND YEAR(dateviagem) = @ano AND situacao = 'Pendente'  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotDiaMesAnoPend")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND YEAR(dateviagem) = @ano AND situacao = 'Pendente' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaMesAnoPend")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND YEAR(dateviagem) = @ano AND situacao = 'Pendente' AND  placacarro=@placa  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaMesAnoConc" || comando == "MotDiaMesAnoConc" || comando == "PlacaDiaMesAnoConc")
                {
                    if (comando == "TodosDiaMesAnoConc")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND YEAR(dateviagem) = @ano AND situacao = 'Realizada'  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "MotDiaMesAnoConc")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND YEAR(dateviagem) = @ano AND situacao = 'Realizada' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaMesAnoConc")
                    {
                        sql = "SELECT * FROM viagens WHERE MONTH(dateviagem) = @mes AND DAY(dateviagem) = @dia AND YEAR(dateviagem) = @ano AND situacao = 'Realizada' AND  placacarro=@placa  ORDER BY DATE_FORMAT(dateviagem, '%d-%m') ";
                    }
                }
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@dia", dia);
                cmd.Parameters.AddWithValue("@mes", mes);
                cmd.Parameters.AddWithValue("@ano", ano);
                cmd.Parameters.AddWithValue("@nomemotorista", nomemotorista);
                cmd.Parameters.AddWithValue("@placa", placa);
                con.Open();
                List<Viagens> listaViagens = new List<Viagens>();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Motorista motorista = new Motorista();
                    Veiculos veiculos = new Veiculos();
                    Viagens viagens = new Viagens();
                    viagens.Motorista = motorista;
                    viagens.Veiculos = veiculos;
                    viagens.Motorista.Nome = (String)dr["nomemotorista"];
                    viagens.Motorista.CPF = (String)dr["cpfmotorista"];
                    viagens.Veiculos.Placa = (String)dr["placacarro"];
                    viagens.ID = (int)dr["id"];
                    viagens.dateViagem = (DateTime)dr["dateviagem"];
                    viagens.dateViagemFeita = (DateTime)dr["dateviagemfeita"];
                    viagens.Situacao = (String)dr["situacao"];
                    listaViagens.Add(viagens);
                }
                return listaViagens;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }


        //Entrada e Saida

        //Insere um novo registro de Entrada/Saida
        public void InsertEntradaSaida(EntradaSaida entradaSaida)
        {
            try
            {
                String sql = "INSERT INTO entradasaida(placacarro, nomemotorista, datees, hrentrada, hrsaida, kminicial, kmfinal) VALUES (@placacarro, @nomemotorista, @datees, @hrentrada, @hrsaida, @kminicial, @kmfinal)";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@placacarro", entradaSaida.Veiculos.Placa);
                cmd.Parameters.AddWithValue("@nomemotorista", entradaSaida.Motorista.Nome);
                cmd.Parameters.AddWithValue("@datees", entradaSaida.Data);
                cmd.Parameters.AddWithValue("@hrentrada", entradaSaida.HrEntrada);
                cmd.Parameters.AddWithValue("@hrsaida", entradaSaida.HrSaida);
                cmd.Parameters.AddWithValue("@kminicial", entradaSaida.KmInicial);
                cmd.Parameters.AddWithValue("@kmfinal", entradaSaida.KmFinal);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Faz o update de uma entrada/saida
        public void UpdateEntradaSaida(EntradaSaida entradaSaida)
        {
            try
            {
                String sql = "UPDATE entradasaida SET datees=@datees, nomemotorista=@nomemotorista, placacarro=@placacarro, hrentrada=@hrentrada, hrsaida=@hrsaida, kminicial=@kminicial, kmfinal=@kmfinal WHERE id=@id";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", entradaSaida.ID);
                cmd.Parameters.AddWithValue("@datees", entradaSaida.Data);
                cmd.Parameters.AddWithValue("@nomemotorista", entradaSaida.Motorista.Nome);
                cmd.Parameters.AddWithValue("@placacarro", entradaSaida.Veiculos.Placa);
                cmd.Parameters.AddWithValue("@hrentrada", entradaSaida.HrEntrada);
                cmd.Parameters.AddWithValue("@hrsaida", entradaSaida.HrSaida);
                cmd.Parameters.AddWithValue("@kminicial", entradaSaida.KmInicial);
                cmd.Parameters.AddWithValue("@kmfinal", entradaSaida.KmFinal);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Deleta uma entrada/saida
        public void DeleteEntradaSaida(EntradaSaida entradaSaida)
        {
            try
            {
                String sql = "DELETE FROM entradasaida WHERE id=@id";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", entradaSaida.ID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna uma entrada/saida pelo ID
        public EntradaSaida SelectEntradaSaidaByID(int id)
        {
            try
            {
                String sql = "SELECT * FROM entradasaida WHERE id = @id";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                MySqlDataReader dr;
                EntradaSaida entradaSaida = new EntradaSaida();
                Motorista motorista = new Motorista();
                Veiculos veiculos = new Veiculos();
                entradaSaida.Motorista = motorista;
                entradaSaida.Veiculos = veiculos;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    entradaSaida.Data = Convert.ToDateTime(dr["datees"]);
                    entradaSaida.KmInicial = dr["kminicial"].ToString();
                    entradaSaida.KmFinal = dr["kmfinal"].ToString();
                    entradaSaida.Motorista.Nome = dr["nomemotorista"].ToString();
                    entradaSaida.Veiculos.Placa = dr["placacarro"].ToString();
                    entradaSaida.HrEntrada = dr["hrentrada"].ToString();
                    entradaSaida.HrSaida = dr["hrsaida"].ToString();
                }
                return entradaSaida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna uma lista com todos os tipos de entrada/saida
        public List<EntradaSaida> ListaEntradaSaida(string comando, string dia, string mes, string ano, string nomemotorista, string placa)
        {
            try
            {
                String sql = "";

                if (comando == "Todos" || comando == "Mot" || comando == "Placa")
                {
                    if (comando == "Todos")
                    {
                        sql = "SELECT * FROM entradasaida ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "Mot")
                    {
                        sql = "SELECT * FROM entradasaida WHERE nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "Placa")
                    {
                        sql = "SELECT * FROM entradasaida WHERE placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDia" || comando == "MotDia" || comando == "PlacaDia")
                {
                    if (comando == "TodosDia")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotDia")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaDia")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosMes" || comando == "MotMes" || comando == "PlacaMes")
                {
                    if (comando == "TodosMes")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotMes")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaMes")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosAno" || comando == "MotAno" || comando == "PlacaAno")
                {
                    if (comando == "TodosAno")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotAno")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaAno")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosPend" || comando == "MotPend" || comando == "PlacaPend")
                {
                    if (comando == "TodosPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE situacao ='Pendente' ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE situacao ='Pendente' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE situacao ='Pendente' AND placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosConc" || comando == "MotConc" || comando == "PlacaConc")
                {
                    if (comando == "TodosConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE situacao = 'Realizada' ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE situacao = 'Realizada' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE situacao = 'Realizada' AND placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaMes" || comando == "MotDiaMes" || comando == "PlacaDiaMes")
                {
                    if (comando == "TodosDiaMes")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND MONTH(datees) = @mes ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotDiaMes")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND MONTH(datees) = @mes AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaMes")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND MONTH(datees) = @mes AND placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaAno" || comando == "MotDiaAno" || comando == "PlacaDiaAno")
                {
                    if (comando == "TodosDiaAno")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND YEAR(datees) = @ano ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotDiaAno")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND YEAR(datees) = @ano AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaAno")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND YEAR(datees) = @ano AND placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaPend" || comando == "MotDiaPend" || comando == "PlacaDiaPend")
                {
                    if (comando == "TodosDiaPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND situacao = 'Pendente' ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotDiaPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND situacao = 'Pendente' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND situacao = 'Pendente' AND placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaConc" || comando == "MotDiaConc" || comando == "PlacaDiaConc")
                {
                    if (comando == "TodosDiaConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND situacao = 'Realizada' ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotDiaConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND situacao = 'Realizada' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE DAY(datees) = @dia AND situacao = 'Realizada' AND placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosMesAno" || comando == "MotMesAno" || comando == "PlacaMesAno")
                {
                    if (comando == "TodosMesAno")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND YEAR(datees) = @ano ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotMesAno")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND YEAR(datees) = @ano AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaMesAno")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND YEAR(datees) = @ano AND placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosMesPend" || comando == "MotMesPend" || comando == "PlacaMesPend")
                {
                    if (comando == "TodosMesPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND situacao = 'Pendente' ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotMesPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND situacao = 'Pendente' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaMesPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND situacao = 'Pendente' AND placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosMesConc" || comando == "MotMesConc" || comando == "PlacaMesConc")
                {
                    if (comando == "TodosMesConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND situacao = 'Realizada'  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotMesConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND situacao = 'Realizada' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaMesConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND situacao = 'Realizada' AND placacarro=@placa  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }

                }
                else if (comando == "TodosAnoPend" || comando == "MotAnoPend" || comando == "PlacaAnoPend")
                {
                    if (comando == "TodosAnoPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND situacao = 'Pendente' ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotAnoPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND situacao = 'Pendente' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaAnoPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND situacao = 'Pendente' AND placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosAnoConc" || comando == "MotAnoConc" || comando == "PlacaAnoConc")
                {
                    if (comando == "TodosAnoConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND situacao = 'Realizada' ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotAnoConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND situacao = 'Realizada' AND nomemotorista=@nomemotorista ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaAnoConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND situacao = 'Realizada' AND placacarro=@placa ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosMesAnoPend" || comando == "MotMesAnoPend" || comando == "PlacaMesAnoPend")
                {
                    if (comando == "TodosMesAnoPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND YEAR(datees) = @ano AND situacao = 'Pendente'  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotMesAnoPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND YEAR(datees) = @ano AND situacao = 'Pendente' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaMesAnoPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND YEAR(datees) = @ano AND situacao = 'Pendente' AND placacarro=@placa  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosMesAnoConc" || comando == "MotMesAnoConc" || comando == "PlacaMesAnoConc")
                {
                    if (comando == "TodosMesAnoConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND YEAR(datees) = @ano AND situacao = 'Realizada'  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotMesAnoConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND YEAR(datees) = @ano AND situacao = 'Realizada' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaMesAnoConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND YEAR(datees) = @ano AND situacao = 'Realizada' AND placacarro=@placa  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaMesPend" || comando == "MotDiaMesPend" || comando == "PlacaDiaMesPend")
                {
                    if (comando == "TodosDiaMesPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND situacao = 'Pendente'  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotDiaMesPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND situacao = 'Pendente' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaMesPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND situacao = 'Pendente' AND placacarro=@placa  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaMesConc" || comando == "MotDiaMesConc" || comando == "PlacaDiaMesConc")
                {
                    if (comando == "TodosDiaMesConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND situacao = 'Realizada'  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotDiaMesConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND situacao = 'Realizada' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaMesConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND situacao = 'Realizada' AND placacarro=@placa  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaAnoPend" || comando == "MotDiaAnoPend" || comando == "PlacaDiaAnoPend")
                {
                    if (comando == "TodosDiaAnoPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND DAY(datees) = @dia AND situacao = 'Pendente'  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotDiaAnoPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND DAY(datees) = @dia AND situacao = 'Pendente' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaAnoPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND DAY(datees) = @dia AND situacao = 'Pendente' AND placacarro=@placa  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaAnoConc" || comando == "MotDiaAnoConc" || comando == "PlacaDiaAnoConc")
                {
                    if (comando == "TodosDiaAnoConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND DAY(datees) = @dia AND situacao = 'Realizada'  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotDiaAnoConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND DAY(datees) = @dia AND situacao = 'Realizada' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaAnoConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE YEAR(datees) = @ano AND DAY(datees) = @dia AND situacao = 'Realizada' AND placacarro=@placa  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaMesAno" || comando == "MotDiaMesAno" || comando == "PlacaDiaMesAno")
                {
                    if (comando == "TodosDiaMesAno")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND YEAR(datees) = @ano  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotDiaMesAno")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND YEAR(datees) = @ano AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaMesAno")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND YEAR(datees) = @ano AND placacarro=@placa  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaMesAnoPend" || comando == "MotDiaMesAnoPend" || comando == "PlacaDiaMesAnoPend")
                {
                    if (comando == "TodosDiaMesAnoPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND YEAR(datees) = @ano AND situacao = 'Pendente'  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotDiaMesAnoPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND YEAR(datees) = @ano AND situacao = 'Pendente' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaMesAnoPend")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND YEAR(datees) = @ano AND situacao = 'Pendente' AND  placacarro=@placa  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                else if (comando == "TodosDiaMesAnoConc" || comando == "MotDiaMesAnoConc" || comando == "PlacaDiaMesAnoConc")
                {
                    if (comando == "TodosDiaMesAnoConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND YEAR(datees) = @ano AND situacao = 'Realizada'  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "MotDiaMesAnoConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND YEAR(datees) = @ano AND situacao = 'Realizada' AND nomemotorista=@nomemotorista  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                    else if (comando == "PlacaDiaMesAnoConc")
                    {
                        sql = "SELECT * FROM entradasaida WHERE MONTH(datees) = @mes AND DAY(datees) = @dia AND YEAR(datees) = @ano AND situacao = 'Realizada' AND  placacarro=@placa  ORDER BY DATE_FORMAT(datees, '%d-%m') ";
                    }
                }
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@dia", dia);
                cmd.Parameters.AddWithValue("@mes", mes);
                cmd.Parameters.AddWithValue("@ano", ano);
                cmd.Parameters.AddWithValue("@nomemotorista", nomemotorista);
                cmd.Parameters.AddWithValue("@placa", placa);
                con.Open();
                List<EntradaSaida> listaEntradaSaida = new List<EntradaSaida>();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Motorista motorista = new Motorista();
                    Veiculos veiculos = new Veiculos();
                    EntradaSaida entradaSaida = new EntradaSaida();
                    entradaSaida.Motorista = motorista;
                    entradaSaida.Veiculos = veiculos;
                    entradaSaida.Motorista.Nome = (String)dr["nomemotorista"];
                    entradaSaida.Veiculos.Placa = (String)dr["placacarro"];
                    entradaSaida.ID = (int)dr["id"];
                    entradaSaida.Data = (DateTime)dr["datees"];
                    entradaSaida.HrEntrada = (String)dr["hrentrada"];
                    entradaSaida.HrSaida = (String)dr["hrsaida"];
                    entradaSaida.KmInicial = (String)dr["kminicial"];
                    entradaSaida.KmFinal = (String)dr["kmfinal"];
                    listaEntradaSaida.Add(entradaSaida);
                }
                return listaEntradaSaida;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




        //Adm

        //Seleciona um ADM pelo Login
        public Adm SelectAdmByLogin(string login)
        {
            try
            {
                string sql = "SELECT * FROM adm WHERE login = @login";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);
                con.Open();
                MySqlDataReader dr;
                Adm adm = new Adm();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    adm.Login = dr["login"].ToString();
                    adm.Password = dr["passwrd"].ToString();
                }
                return adm;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Insere o último ADM no CheckLogin
        public void InsertLastAdm(UltimoAdm ultimoAdm)
        {
            try
            {
                String sql = "INSERT INTO checklogin (ultimoLogin, ultimaSenha, checked) VALUES (@ultimoLogin, @ultimaSenha,@checked)";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ultimoLogin", ultimoAdm.Login);
                cmd.Parameters.AddWithValue("@ultimaSenha", ultimoAdm.Password);
                cmd.Parameters.AddWithValue("@checked", ultimoAdm.CheckedS);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Seleciona o último ADM pelo estado do Check
        public UltimoAdm SelectUltAdmByState()
        {
            try
            {
                string sql = "SELECT * FROM checklogin WHERE checked = 'Y'";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader dr;
                UltimoAdm ultimoAdm = new UltimoAdm();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    ultimoAdm.Login = dr["ultimoLogin"].ToString();
                    ultimoAdm.Password = dr["ultimaSenha"].ToString();
                    ultimoAdm.CheckedS = dr["checked"].ToString();
                }
                return ultimoAdm;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
