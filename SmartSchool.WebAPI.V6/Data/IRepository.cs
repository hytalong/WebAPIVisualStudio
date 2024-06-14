﻿using SmartSchool.WebAPI.Models;
using SmartSchool.WebAPI.V6.Helpers;

namespace SmartSchool.WebAPI.V6.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();


        //Alunos
        Task<PageList<Aluno>> GetAllAlunosAsync(PageParams pageParams, bool includeProfessor = false);
        Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false);
        Aluno GetAlunoById(int alunoId, bool includeProfessor = false);

        // Professores
        Professor[] GetAllProfessores(bool includeAlunos = false);
        Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAlunos = false);
        Professor GetProfessoresById(int professorId, bool includeProfessor = false);
    }
}
