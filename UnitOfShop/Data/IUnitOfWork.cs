﻿namespace UnitOfShop.Data
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
