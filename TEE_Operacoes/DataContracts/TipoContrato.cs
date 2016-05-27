using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TEE_Operacoes.DataContracts
{
    [DataContract]
    public class TipoContrato
    {
        [DataMember]
        public int TipoContratoID { get; set; }
        [DataMember]
        public string TipoContratoString { get; set; }
    }
}