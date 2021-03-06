using System;
using System.Collections.Generic;
using System.Text;

namespace CartoPrime.Data.CA.Models
{
    public class TeamCA
    {
        public int time_id { get; set; }

        public string mensagem { get; set; }
        public int rodada_atual { get; set; }
        public String patrimonio { get; set; }
        public String patrimonioString { get { return "C$ " + patrimonio; } }
        public String variacao_patrimonio_color { get { if (variacao_patrimonio_count <= 0) return "red"; else return "green"; } }
        public double? variacao_patrimonio_count { get; set; }
        public string variacao_patrimonio_string { get { return "C$ " + variacao_patrimonio_count; } }
        public String capitao_id { get; set; }

        public string pontos
        {
            get
            {
                var _pont = pontos_count == null ? 0.00 : double.Parse(pontos_count.ToString());
                return _pont.ToString("F2").Replace(",", ".") + "pts"; ;

            }
            set { }
        }

        public string clube_string { get; set; }

        public int temporada_inicial { get; set; }
        public string rodada_time_id { get; set; }
        public int clube_id { get; set; }
        public string scouts_print { get; set; }
        public bool assinante { get; set; }
        public string foto_perfil { get; set; }
        public string nome { get; set; }
        public string nome_cartola { get; set; }
        public string slug { get; set; }
        public string url_escudo_png { get; set; }
        public string url_escudo_svg { get; set; }
        public string facebook_id { get; set; }
        public string assinanteCaminho { get; set; }
        public string image_add { get; set; }
        public bool item_enable { get; set; }
        public int esquema_id { get; set; }
        public string CartoleiroEsquema { get { return $"{nome_cartola} - {Schemes.GetSchemes(esquema_id)}"; } }
        public int liga_id { get; set; }
        public string foto_clube { get; set; }
        public string TempoCartola
        {
            get
            {
                if (time_id == 13924668)
                    return (DateTime.Now.Year - 2012) + " anos de cartola";
                else
                    return (DateTime.Now.Year - temporada_inicial) + " anos de cartola";
            }
        }
        public string mediaPrint { get { return "ME Rodada " + String.Format(@"{0:n}", pontos_count / jogados_cont).Replace(",", "."); } }
        public string posicao { get; set; }
        public int jogados_cont { get; set; }
        public string jogados { get { return jogados_cont.ToString() + "\n12"; } set { } }
        public double? pontos_count { get; set; }
        public int GCount { get; set; }
        public int ACount { get; set; }
        public int DSCount { get; set; }
        public int DECount { get; set; }
        public int SGCount { get; set; }
        public string ScoutString { get { return $"DS {DSCount} | DE {DECount} | SG {SGCount}"; } }

    }
}
