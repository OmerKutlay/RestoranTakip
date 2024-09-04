﻿using RestoranTakip.Business.Abstract;
using RestoranTakip.Models;
using RestoranTakip.Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Business.Concrete
{
    public class TableService : ITableService
    {
        private readonly IRepository<Table> _tableRepository;
        
        public TableService(IRepository<Table> tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public Table Add(Table table)
        {
            return _tableRepository.Add(table);
        }

        public bool Delete(int TableId)
        {
            _tableRepository.Delete(TableId);
            return true;
        }

        public IQueryable<Table> GetAll()
        {
            return _tableRepository.GetAll(c => !c.IsDeleted);
        }

        public Table Update(Table table)
        {
            return _tableRepository.Update(table);
        }
    }
}