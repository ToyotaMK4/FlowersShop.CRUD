using FlowersShop.CRUD.Models;

namespace FlowersShop.CRUD.Services.Flowerr
{
    internal interface IFlowerService
    {
        Flower[] ReadAllFlowers();
        Flower GetFlower(int id);
        Flower CreateFlower(Flower flower);
        Flower ModifyFlower(Flower flower);
        bool RemoveFlower(int id);
    }
}