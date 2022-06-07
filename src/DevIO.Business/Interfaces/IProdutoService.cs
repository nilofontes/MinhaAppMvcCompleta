using RunIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunIO.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Atualizar(Produto produto);
    }
}
