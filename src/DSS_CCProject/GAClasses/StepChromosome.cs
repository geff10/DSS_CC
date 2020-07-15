using GeneticSharp.Domain.Chromosomes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSS_CCProject.GAClasses
{
    public class StepChromosome : ChromosomeBase
    {
        public StepChromosome() : base(1)
        {
        }

        public StepChromosome(int length) : base(length)
        {
        }

        public override IChromosome CreateNew()
        {
            return new StepChromosome();
        }

        public override Gene GenerateGene(int geneIndex)
        {
            throw new NotImplementedException();
        }
    }
}
