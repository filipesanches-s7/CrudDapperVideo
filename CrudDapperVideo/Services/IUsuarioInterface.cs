using CrudDapperVideo.Dto;
using CrudDapperVideo.Models;

namespace CrudDapperVideo.Services
{
    public interface IUsuarioInterface
    {

        Task<ResponseModel<List<UsuarioListarDto>>> BuscarUsuarios();
        Task<ResponseModel<UsuarioListarDto>> BuscarUsuarioPorId(int usuarioId);


    }
}
