﻿using System.Data;
using Restaurant_management.DTO;

namespace Restaurant_management.DecoratorFood
{
    public class CheeseAndBiscuits:FoodDecorator
    {
        public override float GetPrice()
        {
            return this.price + food.GetPrice();
        }


        public override string GetName()
        {
            return this.name + food.GetName();
        }

        public override int GetDCategory()
        {
            return this.iDCategory + food.IDCategory;
        }

        public override int GetID()
        {
            return this.id;
        }

        private Food food;

        public CheeseAndBiscuits(int id, string name, int iDCategory, float price, Food food) : base(id, name, iDCategory, price)
        {
            this.food = food;
        }

        public CheeseAndBiscuits(DataRow row, Food food) : base(row)
        {
            this.food = food;
        }
    }
}