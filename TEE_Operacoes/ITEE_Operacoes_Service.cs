
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TEE_Operacoes.DataContracts;

namespace TEE_Operacoes
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITEE_Operacoes_Service
    {
        //----------------------------Bandeira-------------------------------------------------------------
        [OperationContract]
        Bandeira DetalhesBandeira(int id);

        [OperationContract]
        bool CadastrarBandeira(Bandeira bandeira);

        [OperationContract]
        List<Bandeira> TodasBandeiras();

        //----------------------------Tipo de Contrato-----------------------------------------------------
        [OperationContract]
        bool CadastrarContrato(TipoContrato _TipoContrato);

        [OperationContract]
        TipoContrato DetalhesContrato(int id);

        [OperationContract]
        List<TipoContrato> TodosContratos();

        //----------------------------Distribuidora--------------------------------------------------------
        [OperationContract]
        bool CadastrarDistribuidora(Distribuidora _Distribuidora);

        [OperationContract]
        Distribuidora DetalhesDistribuidora(int id);

        [OperationContract]
        List<Distribuidora> TodasDistribuidoras();

        //----------------------------Tipo de SubGrupo-----------------------------------------------------
        [OperationContract]
        bool CadastrarSubGrupo(TipoSubGrupo _SubGrupo);

        [OperationContract]
        TipoSubGrupo DetalhesSubGrupo(int id);

        [OperationContract]
        List<TipoSubGrupo> TodosSubGrupos();

        //----------------------------Tarifa---------------------------------------------------------------
        [OperationContract]
        bool CadastrarTarifa(Tarifa _Tarifa);

        [OperationContract]
        Tarifa DestalhesDaTarifa(int id);

        [OperationContract]
        List<Tarifa> TodasTarifas();

        [OperationContract]
        bool AtualizarTarifa(Tarifa _Tarifa);

        [OperationContract]
        bool DeletarTarifa(Tarifa _Tarifa);

        //----------------------------Usuario---------------------------------------------------------------
        [OperationContract]
        bool CadastrarUsuario(Usuario _Usuario);

        [OperationContract]
        Usuario DestalhesDoUsuario(string email);

        [OperationContract]
        Usuario VerificaAutenticacao(string email, string senha);

        [OperationContract]
        bool AtualizarUsuario(Usuario _Usuario);

        [OperationContract]
        bool DeletarUsuario(Usuario _Usuario);

        [OperationContract]
        List<Usuario> ListarUsuarios(int ClienteID);

        //----------------------------Contas----------------------------------------------------------------
        [OperationContract]
        bool CadastrarConta(Conta _Conta);

        [OperationContract]
        Conta DestalhesDaConta(DateTime dataReferencia, int FabricaID);

        [OperationContract]
        List<Conta> TodasContas(int FabricaID);

        [OperationContract]
        List<Conta> ConsultaEntreDatas(DateTime dataReferencia1, DateTime dataReferencia2, int FabricaID);

        [OperationContract]
        bool AtualizarConta(Conta _Conta);

        [OperationContract]
        bool DeletarConta(Conta _Conta);

        //----------------------------Simulacao----------------------------------------------------------------
        [OperationContract]
        bool GerarSimulacao(int fabricaID);

        //----------------------------Grafico------------------------------------------------------------------
        [OperationContract]
        List<Grafico> DadosParaGrafico(int FabricaID);

    }

}
