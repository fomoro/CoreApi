﻿using Incidencias.Interfaces.AccesoDatos;
using Incidencias.Interfaces.LogicaDeNegocio;
using Incidencias.LogicaDeNegocio.Exceptions;
using Incidencias.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incidencias.LogicaDeNegocio
{
    public class LogicaDeIncidencia : IIncidenciasLogica
    {
        private const string null_perfil = "Perfil";

        IIncidenciasRepositorio _repository;

        public LogicaDeIncidencia(IIncidenciasRepositorio repository)
        {
            _repository = repository;
        }

        public async Task<bool> Actualizar(Incidencia entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(null_perfil);
            }
            return await _repository.Actualizar(entity);
        }

        public async Task<Incidencia> Agregar(Incidencia entity)
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

        public async Task<Incidencia> ObtenerPorId(int id)
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

        public async Task<Incidencia> ObtenerPorNombre(string nombre)
        {
            return await _repository.ObtenerPorNombre(nombre);
        }

        public async Task<IEnumerable<Incidencia>> ObtenerTodos()
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