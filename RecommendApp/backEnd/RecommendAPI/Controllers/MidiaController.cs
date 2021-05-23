using System.Threading.Tasks;
using RecommendAPI.DTOs;
using RecommendAPI.Entities;
using RecommendAPI.Extensions;
using RecommendAPI.Helpers;
using RecommendAPI.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
        public async Task<ActionResult> AddSerie(MidiaDto midiaDto)
        {
            var midia = new Serie();
            var user = await unitOfWork.UserRepository.GetUserByUsernameAsync(midiaDto.Username);
            if (user == null) return BadRequest("Usuario nao encontrado");

            mapper.Map(midiaDto, midia);
            midia.User = user;
            midia.Criado = DateTime.Now;

            unitOfWork.MidiaRepository.AddMedia(midia);

            if (await unitOfWork.Complete())
            {
                MidiaDto newMidia = new MidiaDto();
                mapper.Map(midia, newMidia);
                return Ok(newMidia);
            }

            return BadRequest("Problema ao adicionar Serie");
        }

        [HttpPost("addfilme")]
        public async Task<ActionResult> AddFilme(MidiaDto midiaDto)
        {
            var midia = new Filme();
            var user = await unitOfWork.UserRepository.GetUserByUsernameAsync(midiaDto.Username);
            if (user == null) return BadRequest("Usuario nao encontrado");

            mapper.Map(midiaDto, midia);
            midia.User = user;
            midia.Criado = DateTime.Now;

            unitOfWork.MidiaRepository.AddMedia(midia);

            if (await unitOfWork.Complete())
            {
                MidiaDto newMidia = new MidiaDto();
                mapper.Map(midia, newMidia);
                return Ok(newMidia);
            }


            return BadRequest("Problema ao adicionar Filme");
        }

        [HttpPost("addlivro")]
        public async Task<ActionResult> AddLivro(MidiaDto midiaDto)
        {
            var midia = new Livro();
            var user = await unitOfWork.UserRepository.GetUserByUsernameAsync(midiaDto.Username);
            if (user == null) return BadRequest("Usuario nao encontrado");

            mapper.Map(midiaDto, midia);
            midia.User = user;
            midia.Criado = DateTime.Now;

            unitOfWork.MidiaRepository.AddMedia(midia);

            if (await unitOfWork.Complete())
            {
                MidiaDto newMidia = new MidiaDto();
                mapper.Map(midia, newMidia);
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

      
        [HttpGet("getmidiasadm/{userParams}")]
        public async Task<ActionResult<MidiaDto>> GetMidiasAdm([FromQuery] UserParams userParams)
        {
            userParams.Avaliado = false;
            userParams.CurrentUsername = User.GetUsername();
            var midias = await unitOfWork.MidiaRepository.GetMidiassAsync(userParams);

            Response.AddPaginationHeader(midias.CurrentPage, midias.PageSize,
                midias.TotalCount, midias.TotalPages);

            return Ok(midias);
        }

        [HttpGet("{id}", Name = "GetMidia")]
        public async Task<ActionResult<MidiaDto>> GetMidia(int id)
        {
            var midia = await unitOfWork.MidiaRepository.GetMidiaAsync(id);

            return Ok(midia);
        }

        [HttpGet("aprovamidia/{id}")]
        public async Task<ActionResult<bool>> AprovaMidia(int id)
        {
            unitOfWork.MidiaRepository.AprovaMidia(id);

            if (await unitOfWork.Complete())
            {
                return Ok(true);
            }

            return BadRequest("Problema ao aprovar Midia");
        }

        [HttpGet("MidiaDuplicadaAsync/{titulo}")]
        private async Task<IList<MidiaDto>> MidiaDuplicadaAsync(string titulo)
        {
            return await unitOfWork.MidiaRepository.VeridicaMidiaDuplicada(titulo);

        }

    }
}