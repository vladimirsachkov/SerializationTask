// See https://aka.ms/new-console-template for more information
using SerializationTask.Model;
using SerializationTask.Service;

IPersonGeneration personGeneration = new PersonGenerationImpl();

personGeneration.hello;