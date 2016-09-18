﻿namespace ReactiveGit.Gui.Base.Model.Factories
{
    using ReactiveGit.Managers;

    /// <summary>
    /// Factory for generating classes relating to the repository.
    /// </summary>
    public interface IRepositoryFactory
    {
        /// <summary>
        /// Creates a new repository for the specified repository directory.
        /// </summary>
        /// <param name="repositoryDirectory">The path to the repository.</param>
        /// <returns>The repository details.</returns>
        IRepositoryDetails CreateRepositoryDetails(string repositoryDirectory);

        /// <summary>
        /// Creates a new repository creator.
        /// </summary>
        /// <returns>The repository creator.</returns>
        IRepositoryCreator CreateRepositoryCreator();
    }
}