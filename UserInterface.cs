﻿using Spectre.Console;
using STUDY.OOP.LibraryManagement;
using STUDY.OOP.LibraryManagement.Controllers;
using STUDY.OOP.LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static STUDY.OOP.LibraryManagement.Enums;

namespace STUDY.OOP.LibraryManagement
{
    internal class UserInterface
    {
        private readonly BookController _booksController = new();
        private readonly MagazineController _magazinesController = new();
        private readonly NewspaperController _newspapersController = new();

        internal void MainMenu()
        {
            while (true)
            {
                Console.Clear();

                var actionChoice = AnsiConsole.Prompt(
                    new SelectionPrompt<MenuAction>()
                    .Title("What do you want to do next?")
                    .AddChoices(Enum.GetValues<MenuAction>()));

                var itemTypeChoice = AnsiConsole.Prompt(
                    new SelectionPrompt<ItemType>()
                    .Title("Select the type of item:")
                    .AddChoices(Enum.GetValues<ItemType>()));

                switch (actionChoice)
                {
                    case MenuAction.ViewItem:
                        ViewItems(itemTypeChoice);
                        break;
                    case MenuAction.AddItem:
                        AddItem(itemTypeChoice);
                        break;
                    case MenuAction.DeleteItem:
                        DeleteItem(itemTypeChoice);
                        break;
                }


            }
        }

        private void ViewItems(ItemType itemType)
        {
            switch (itemType)
            {
                case ItemType.Book:
                    _booksController.ViewItems();
                    break;
                case ItemType.Magazine:
                    _magazinesController.ViewItems();
                    break;
                case ItemType.Newspaper:
                    _newspapersController.ViewItems();
                    break;
            }
        }

        private void AddItem(ItemType itemType)
        {
            switch (itemType)
            {
                case ItemType.Book:
                    _booksController.AddItem();
                    break;
                case ItemType.Magazine:
                    _magazinesController.AddItem();
                    break;
                case ItemType.Newspaper:
                    _newspapersController.AddItem();
                    break;
            }
        }

        private void DeleteItem(ItemType itemType)
        {
            switch (itemType)
            {
                case ItemType.Book:
                    _booksController.DeleteItem();
                    break;
                case ItemType.Magazine:
                    _magazinesController.DeleteItem();
                    break;
                case ItemType.Newspaper:
                    _newspapersController.DeleteItem();
                    break;
            }
        }
    }
}
