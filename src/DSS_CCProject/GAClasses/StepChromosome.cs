using GeneticSharp.Domain.Chromosomes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSS_CCProject.GAClasses
{
    public class StepChromosome : ChromosomeBase
    {
        private StepGeneValueWrapper genome;
        private Random rand = new Random();
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
            Gene gene = new Gene(genome[geneIndex]);
            List<Machine> matchingMachines = CycleFrameFactory.Machines
                .Where(m => m.OperationType == (gene.Value as Step).MachineType).ToList();
            (gene.Value as Step).Machine = matchingMachines[rand.Next(0, matchingMachines.Count - 1)];
            return gene;
        }
    }
}
