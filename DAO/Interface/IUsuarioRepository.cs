﻿using Models;
using Models.DTO.UsuarioDTO;

namespace DAO.Interface;

public interface IUsuarioRepository
{
    Task<ResponseUsuarioDTO> Post(Usuario usuario);
    Task<List<ResponseUsuarioDTO>> Get();
    Task<ResponseUsuarioDTO?> GetById(int id);
    Task Put(Usuario usuario);
    Task Delete(int id);
    Task<ResponseUsuarioDTO> Login(String email, String password);
    Task UpdateValorReceitas(int id);
    Task UpdateValorDespesas(int id);
    Task CheckStability(int id);
}