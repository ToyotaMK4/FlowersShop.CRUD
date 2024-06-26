﻿using FlowersShop.CRUD.Models;

namespace FlowersShop.CRUD.Brokers.Storage
{
    internal interface IStorageBroker
    {
        Flower ReadFlower(int id);
        Flower[] GetAllFlowers();
        Flower AddFlower(Flower flower);
        Flower Update(Flower flower);
        bool Delete(int id);
    }
}