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
    class BLL
    {

        DAL dal = null;


        //Veículos

        //Insere um novo veículo
        public void novoVeiculo(Veiculos veiculos)
        {
            try
            {
                dal = new DAL();
                dal.InsertVeiculo(veiculos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Seleciona todos os veículos retornando um DataTable
        public DataTable SelecionaVeiculos()
        {
            DataTable dt = new DataTable();

            try
            {
                dal = new DAL();
                dt = dal.SelectVeiculos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        //Lista um veículo pela placa.
        public Veiculos ListaVeiculosPorPlaca(string placa)
        {
            try
            {
                dal = new DAL();
                return dal.selectVeiculosByPlaca(placa);
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }

        //Retorna uma lista com os ultimos veículos adicionados
        public List<Veiculos> listaUltVeiculos()
        {
            try
            {
                DAL dal = new DAL();
                return dal.selectListUltVeiculos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna uma lista com todos os veículos 
        public List<Veiculos> listaAllVeiculos()
        {
            try
            {
                DAL dal = new DAL();
                return dal.selectListAllVeiculos();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Retorna um AutoComplete com todas as placas dos veiculos
        public AutoCompleteStringCollection AutoCompletarPlaca()
        {
            DAL dal = new DAL();
            return dal.AutoCompletePlaca();
        }

        //Updata um veículo
        public void UpdateVeiculo(Veiculos veiculos)
        {
            try
            {
                dal = new DAL();
                dal.UpdateVeiculo(veiculos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Deleta um veiculo
        public void DeleteVeiculo(Veiculos veiculos)
        {
            try
            {
                dal = new DAL();
                dal.DeleteVeiculo(veiculos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Motorista

        //Insere um novo motorista
        public void novoMotorista(Motorista motorista)
        {
            try
            {
                dal = new DAL();
                dal.InsertMotorista(motorista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Lista um motorista pelo CPF
        public Motorista ListaMotoristaPorCPF(string cpf)
        {
            try
            {
                dal = new DAL();
                return dal.SelectMotoristaByCPF(cpf);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Lista um motorista por nome
        public Motorista ListaMotoristaPorNome(string nome)
        {
            try
            {
                dal = new DAL();
                return dal.SelectMotoristaByNome(nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna um DataTable com o nome de todos os motoristas.
        public DataTable selecionaNomeMotorista()

        {
            DataTable tb = new DataTable();
            try
            {

                DAL dal = new DAL();

                tb = dal.selectNomeMotoristas();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        //Retorna uma lista com os últimos motoristas adicionados
        public List<Motorista> listaUltMotoristas()
        {
            try
            {
                DAL dal = new DAL();
                return dal.selectListUltMotoristas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna uma lista com todos os motoristas
        public List<Motorista> listaTodosMotoristas()
        {
            try
            {
                DAL dal = new DAL();
                return dal.selectListAllMotoristas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna um AutoComplete com o nome de todos os motoristas
        public AutoCompleteStringCollection AutoCompletarNome()
        {
            DAL dal = new DAL();
            return dal.AutoCompleteName();
        }

        //Retorna um AutoComplete com o CPF de todos os motoristas
        public AutoCompleteStringCollection AutoCompletarCPF()
        {
            DAL dal = new DAL();
            return dal.AutoCompleteCPF();
        }

        //Updata um Motorista
        public void UpdateMotorista(Motorista motorista)
        {
            try
            {
                dal = new DAL();
                dal.UpdateMotorista(motorista);
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
                dal = new DAL();
                dal.DeleteMotorista(motorista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Viagens

        //Insere uma nova viagem
        public void novaViagem(Viagens viagens)
        {
            try
            {
                dal = new DAL();
                dal.InsertViagem(viagens);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna uma Viagem pelo ID
        public Viagens ListaViagemPorID(int id)
        {
            try
            {
                dal = new DAL();
                return dal.SelectViagemByID(id);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        //Update Viagem
        public void UpdateViagem(Viagens viagens)
        {
            try
            {
                dal = new DAL();
                dal.UpdateViagem(viagens);
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
                dal = new DAL();
                dal.DeleteViagem(viagens);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //Retorna uma lista com todas as viagens
        public List<Viagens> listaViagens(string comando, string dia, string mes, string ano, string nomemotorista, string placa)
        {
            try
            {
                DAL dal = new DAL();
                return dal.ListaViagens(comando, dia, mes, ano, nomemotorista, placa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        //Entrada/Saída

        //Insere um novo registro de entrada/saida
        public void novaEntradaSaida(EntradaSaida entradaSaida)
        {
            try
            {
                dal = new DAL();
                dal.InsertEntradaSaida(entradaSaida);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna uma EntradaSaida pelo ID
        public EntradaSaida ListaEntradaSaidaPorID(int id)
        {
            try
            {
                dal = new DAL();
                return dal.SelectEntradaSaidaByID(id);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        //Update EntradaSaida
        public void UpdateEntradaSaida(EntradaSaida entradaSaida)
        {
            try
            {
                dal = new DAL();
                dal.UpdateEntradaSaida(entradaSaida);
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
                dal = new DAL();
                dal.DeleteEntradaSaida(entradaSaida);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna uma lista com todas as entradas e saidas
        public List<EntradaSaida> listaEntradaSaida(string comando, string dia, string mes, string ano, string nomemotorista, string placa)
        {
            try
            {
                DAL dal = new DAL();
                return dal.ListaEntradaSaida(comando, dia, mes, ano, nomemotorista, placa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //ADM

        //Seleciona um ADM por login
        public Adm ListaUserPorLogin(string login)
        {
            try
            {
                dal = new DAL();
                return dal.SelectAdmByLogin(login);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Insere o ultimo ADM logado
        public void novoUltAdm(UltimoAdm ultimoAdm)
        {
            try
            {
                dal = new DAL();
                dal.InsertLastAdm(ultimoAdm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Lista o estado do lembrar-senha
        public UltimoAdm ListaUltAdmState()
        {
            try
            {
                dal = new DAL();
                return dal.SelectUltAdmByState();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




































    }
}
