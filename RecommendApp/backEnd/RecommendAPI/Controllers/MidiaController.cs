using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using RecommendAPI.Data;
using RecommendAPI.DTOs;
using RecommendAPI.Entities;
using RecommendAPI.Extensions;
using RecommendAPI.Helpers;
using RecommendAPI.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using RecommendAPI.Entities.Enums;

namespace RecommendAPI.Controllers
{

    public class MidiaController : BaseApiController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public MidiaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpPost("addserie")]
        public async Task<ActionResult> AddSerie(SerieDto serieDto)
        {
            var midia = new Serie();
            var user = await unitOfWork.UserRepository.GetUserByUsernameAsync(serieDto.Username);
            if (user == null) return BadRequest("Usuario nao encontrado");

            mapper.Map(serieDto, midia);
            midia.User = user;
            midia.Criado = DateTime.Now;


            foreach (var e in serieDto.ElencosDto)
            {
                midia.Elencos.Add(new Elenco { Nome = e.Nome });
            }

            unitOfWork.MidiaRepository.AddMedia(midia);

            if (await unitOfWork.Complete())
            {
                SerieDto newserieDto = new SerieDto();
                mapper.Map(midia, newserieDto);

                foreach (var e in midia.Elencos)
                {
                    newserieDto.ElencosDto.Add(new ElencoDto { Nome = e.Nome, Id = e.Id });
                }

                return Ok(newserieDto);


            }

            return BadRequest("Problema ao adicionar Serie");
        }

        [HttpPost("addfilme")]
        public async Task<ActionResult> AddFilme(FilmeDto filmeDto)
        {
            var midia = new Filme();
            var user = await unitOfWork.UserRepository.GetUserByUsernameAsync(filmeDto.Username);
            if (user == null) return BadRequest("Usuario nao encontrado");

            mapper.Map(filmeDto, midia);
            midia.User = user;
            midia.Criado = DateTime.Now;


            foreach (var e in filmeDto.ElencosDto)
            {
                midia.Elencos.Add(new Elenco { Nome = e.Nome });
            }

            unitOfWork.MidiaRepository.AddMedia(midia);

            if (await unitOfWork.Complete())
            {
                FilmeDto newfilmeDto = new FilmeDto();
                mapper.Map(midia, newfilmeDto);

                foreach (var e in midia.Elencos)
                {
                    newfilmeDto.ElencosDto.Add(new ElencoDto { Nome = e.Nome, Id = e.Id });
                }

                return Ok(newfilmeDto);


            }

            return BadRequest("Problema ao adicionar Filme");
        }

         [HttpPost("addlivro")]
        public async Task<ActionResult> AddLivro(LivroDto livroDto )
        {
            var midia = new Livro();
            var user = await unitOfWork.UserRepository.GetUserByUsernameAsync(livroDto.Username);
            if (user == null) return BadRequest("Usuario nao encontrado");

            mapper.Map(livroDto, midia);
            midia.User = user;
            midia.Criado = DateTime.Now;


            foreach (var e in livroDto.AutoresDto)
            {
                midia.Autores.Add(new Autor { Nome = e.Nome });
            }

            unitOfWork.MidiaRepository.AddMedia(midia);

            if (await unitOfWork.Complete())
            {
                LivroDto newMidia = new LivroDto();
                mapper.Map(midia, newMidia);

                foreach (var e in midia.Autores)
                {
                    newMidia.AutoresDto.Add(new AutorDto { Nome = e.Nome, Id = e.Id });
                }

                return Ok(newMidia);

            }

            return BadRequest("Problema ao adicionar Filme");
        }


        [HttpGet("getmidias")]
        public async Task<ActionResult<MidiaDto>> ListaMidias([FromQuery] UserParams userParams)
        {
            userParams.CurrentUsername = User.GetUsername();
            var midias = await unitOfWork.MidiaRepository.GetMidiassAsync(userParams);

            Response.AddPaginationHeader(midias.CurrentPage, midias.PageSize,
                midias.TotalCount, midias.TotalPages);

            return Ok(midias);
        }

    }
}