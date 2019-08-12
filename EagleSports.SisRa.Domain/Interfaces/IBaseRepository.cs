﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Domain.Interfaces
{
    public interface IBaseRepository<TEntity>: IDisposable where TEntity: class
    {
        void Adicionar(TEntity entity);
        void ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }
}