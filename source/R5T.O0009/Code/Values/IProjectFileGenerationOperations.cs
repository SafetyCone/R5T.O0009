using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.T0131;
using R5T.T0172;
using R5T.T0187;
using R5T.T0198;


namespace R5T.O0009
{
    [ValuesMarker]
    public partial interface IProjectFileGenerationOperations : IValuesMarker
    {
        public async Task Create_BlazorClient(
            IProjectFilePath projectFilePath,
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl)
        {
            await Instances.ProjectFileContextOperator.In_New_ProjectFileContext(
                projectFilePath,
                Instances.ProjectFileContextOperations.Setup_BlazorClientProjectFile(
                    projectDescription,
                    repositoryUrl));
        }

        public async Task Create_WebServerForBlazorClient(
            IProjectFilePath projectFilePath,
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl,
            IProjectFilePath clientProjectFilePath)
        {
            await Instances.ProjectFileContextOperator.In_New_ProjectFileContext(
                projectFilePath,
                Instances.ProjectFileContextOperations.Setup_WebServerForBlazorClientProjectFile(
                    projectDescription,
                    repositoryUrl,
                    clientProjectFilePath));
        }

        public async Task Create_ConsoleProjectFile(
            IProjectFilePath projectFilePath,
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl)
        {
            await Instances.ProjectFileContextOperator.In_New_ProjectFileContext(
                projectFilePath,
                Instances.ProjectFileContextOperations.Setup_ConsoleProjectFile(
                    projectDescription,
                    repositoryUrl));
        }
    }
}
