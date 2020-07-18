using GeneticSharp.Domain.Chromosomes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSS_CCProject.GAClasses
{
    public class StepChromosome : ChromosomeBase
    {
        private StepGeneValueWrapper genome;
        public StepChromosome() : base(1)
        {
        }

        public StepChromosome(int length) : base(length)
        {
        }

        public StepChromosome(StepGeneValueWrapper genomeData) : base (genomeData.Length * genomeData.GetStepCount())
        {
            this.genome = genomeData; //TODO: map joborder
            CreateGenes();
        }

        public override IChromosome CreateNew()
        {
            return new StepChromosome();
        }

        public override Gene GenerateGene(int geneIndex)
        {
            return new Gene(genome[geneIndex]);
        }
    }
}
