using System;
using System.Collections.Generic;
using System.Text;
using MySQLCRUD;
using Xunit;

namespace tests
{
    public class RepoTest
    {
        private MasinaRepository masinaRepository;
        public RepoTest()
        {
            masinaRepository = new MasinaRepository();
        }

       
        [Fact]
        public void testGetAll()
        {
            Assert.Equal(6 ,masinaRepository.getAll().Count);

        }

        [Fact]
        public void testGetModel()
        {
            Assert.NotNull(masinaRepository.getModel("m2"));
        }

        /*[Fact]
        public void testCreate()
        {
            Masina masina = new Masina("m4", 2019, "rosu");
            masinaRepository.create(masina);

            Assert.Contains(masina, masinaRepository.getAll());
        }*/

        [Fact]
        public void testGetById()
        {
            Assert.NotNull(masinaRepository.getById(6));
        }

        [Fact]
        public void testDeleteById()
        {
            if (masinaRepository.getById(9) != null)
                masinaRepository.deleteById(9);
            Assert.Null(masinaRepository.getById(20));
        }

        [Fact]
        public void testUpdateModel()
        {
            masinaRepository.updateModelById(7, "m5");
            Assert.Same("m5", masinaRepository.getById(7).Model);
        }

        [Fact]
        public void testUpdateAn()
        {
            masinaRepository.updateAnById(10, 2020);
            Assert.Same(2020, masinaRepository.getById(10).An);
        }

        [Fact]
        public void testUpdateCuloare()
        {
            masinaRepository.updateCuloareById(11, "alb");
            Assert.Same("alb", masinaRepository.getById(11).Culoare);
        }
    }
}
