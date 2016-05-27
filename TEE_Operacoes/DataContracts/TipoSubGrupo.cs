using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TEE_Operacoes.DataContracts
{
    [DataContract]
    public class TipoSubGrupo
    {
        [DataMember]
        public int TipoSubGrupoID { get; set; }
        [DataMember]
        public string TipoSubGrupoString { get; set; }
    }
}