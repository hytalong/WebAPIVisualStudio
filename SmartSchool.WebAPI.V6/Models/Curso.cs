﻿using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.V6.Models
{
    public class Curso
    {
        public Curso() { }
        public Curso(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }
    }
}
