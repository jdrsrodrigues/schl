using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schl.domain.Entities
{
    public class ApiResponse
    {
        /// <summary>
        /// Código HTTP
        /// </summary>
        public int StatusCode { get; set; }
        /// <summary>
        /// Mensagem de status
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Mensagem
        /// </summary>
        public string? Details { get; set; }
        /// <summary>
        /// Dados retornados
        /// </summary>
        public object? Data { get; set; }
    }
}
