﻿using FubuCsProjFile.ProjectFiles.CsProj;

namespace FubuCsProjFile.Templating.Runtime
{
    public interface IProjectAlteration
    {
        void Alter(CsProjFile file, ProjectPlan plan);
    }
}