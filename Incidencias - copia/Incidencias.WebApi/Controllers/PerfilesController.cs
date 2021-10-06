﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Incidencias.AccesoDatos.Contratos;
using Incidencias.Modelos;
using Incidencias.WebApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Incidencias.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilesController : ControllerBase
    {
        private IRepositorioGenerico<Perfil> _perfilesRepositorio;
        private readonly ILogger<PerfilesController> _logger;
        private readonly IMapper _mapper;

        public PerfilesController(IRepositorioGenerico<Perfil> perfilesRepositorio, 
            ILogger<PerfilesController> logger,
            IMapper mapper)
        {
            this._perfilesRepositorio = perfilesRepositorio;
            this._logger = logger;
            this._mapper = mapper;
        }

        //// GET: api/perfiles
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PerfilVM>>> Get()
        {
            try
            {
                var perfiles= await _perfilesRepositorio.ObtenerTodosAsync();
                return _mapper.Map<List<PerfilVM>>(perfiles);
            }
            catch (Exception excepcion)
            {
                _logger.LogError($"Error en {nameof(Get)}: " + excepcion.Message);
                return BadRequest();
            }
        }

        // GET: api/perfiles/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PerfilVM>> Get(int id)
        {
            var perfil = await _perfilesRepositorio.ObtenerAsync(id);
            if (perfil == null)
            {
                return NotFound();
            }
            return _mapper.Map<PerfilVM>(perfil);
        }

        // POST: api/perfiles
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PerfilVM>> Post(PerfilVM perfilViewModels)
        {
            try
            {
                var perfil = _mapper.Map<Perfil>(perfilViewModels);

                var nuevoPerfil = await _perfilesRepositorio.Agregar(perfil);
                if (nuevoPerfil == null)
                {
                    return BadRequest();
                }

                var nuevoPerfilDto = _mapper.Map<PerfilVM>(nuevoPerfil);
                return CreatedAtAction(nameof(Post), new { id = nuevoPerfilDto.Id }, nuevoPerfilDto);

            }
            catch (Exception excepcion)            
            {
                _logger.LogError($"Error en {nameof(Post)}: " + excepcion.Message);
                return BadRequest();
            }
        }

        // PUT: api/perfiles/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PerfilVM>> Put(int id, [FromBody] PerfilVM perfilViewModels)
        {
            if (perfilViewModels == null)
                return NotFound();


            var perfil = _mapper.Map<Perfil>(perfilViewModels);
            var resultado = await _perfilesRepositorio.Actualizar(perfil);
            if (!resultado)
                return BadRequest();

            return perfilViewModels;
        }

        // DELETE: api/perfiles/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var resultado = await _perfilesRepositorio.Eliminar(id);
                if (!resultado)
                {
                    return BadRequest();
                }
                return NoContent();
            }
            catch (Exception excepcion)
            {
                _logger.LogError($"Error en {nameof(Delete)}: " + excepcion.Message);
                return BadRequest();
            }
        }


    }
}