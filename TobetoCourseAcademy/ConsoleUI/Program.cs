using Business.Concretes;
using Entities.Concretes;

Category category = new Category();
category.Id = 1;
category.Name = "Programlama";

CategoryManager categoryManager = new CategoryManager();

categoryManager.Add(category);

