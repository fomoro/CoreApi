﻿using Incidencias.Interface.LogicaDeNegocio;
using Incidencias.Interfaces;
using Incidencias.Modelos;
using System.Threading.Tasks;

namespace Incidencias.Interfaces.LogicaDeNegocio
{
    public interface IUsuariosLogica : Ilogica<Usuario>
    {
        Task<bool> CambiarContrasena(Usuario usuario);
        Task<bool> CambiarPerfil(Usuario usuario);
        Task<bool> ValidarContrasena(Usuario usuario);
        Task<(bool resultado, Usuario usuario)> ValidarDatosLogin(Usuario datosLoginUsuario);
    }
}
