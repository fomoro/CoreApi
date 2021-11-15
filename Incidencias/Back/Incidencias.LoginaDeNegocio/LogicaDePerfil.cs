﻿using Incidencias.Interfaces.AccesoDatos;
using Incidencias.Interfaces.LogicaDeNegocio;
using Incidencias.LoginaDeNegocio.Exceptions;
using Incidencias.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incidencias.LoginaDeNegocio
{
    public class LogicaDePerfil : IPerfilesLogica
    {
        private const string null_perfil = "Perfil";

        IRepositorioGenerico<Perfil> _repository;

        public LogicaDePerfil(IRepositorioGenerico<Perfil> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Actualizar(Perfil entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(null_perfil);
            }
            return await _repository.Actualizar(entity);
        }

        public async Task<Perfil> Agregar(Perfil entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(null_perfil);
            }
            await _repository.Agregar(entity);
            return entity;
        }

        public async Task<bool> Eliminar(int id)
        {
            try
            {
                return await _repository.Eliminar(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Perfil> ObtenerPorId(int id)
        {
            try
            {
                return await _repository.ObtenerPorId(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Perfil>> ObtenerTodos()
        {
            try
            {
                return await _repository.ObtenerTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}