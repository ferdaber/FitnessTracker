using FitnessTracker.Core.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FitnessTracker.Test.Core.EF
{
    class ExerciseAdminTest
    {
        Exercise exercise;

        public ExerciseAdminTest()
        {
            exercise = new Exercise()
            {
                Type = ExerciseType.Bodyweight
            };
        }

        [Fact]
        public void SetMuscleGroupAsPrimary_EmptyOrNullSet_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => exercise.SetMuscleGroupAsPrimary(new MuscleGroup()));
        }

        [Fact]
        public void AddMuscleGroup_EmptyOrNullSet_GoesToPrimary()
        {
            var m = new MuscleGroup();
            exercise.AddMuscleGroup(m);
            Assert.Equal(exercise.PrimaryMuscleGroup, m);
            Assert.NotNull(exercise.PrimaryMuscleGroupId);
        }

        [Fact]
        public void AddMuscleGroup_HasPrimary_GoesToSecondary()
        {
            var m1 = new MuscleGroup();
            var m2 = new MuscleGroup();
            exercise.AddMuscleGroup(m1);
            exercise.AddMuscleGroup(m2);
            Assert.Equal(exercise.SecondaryMuscleGroups.Count, 1);
            Assert.Equal(exercise._exerciseSecondaryMuscleGroups.Count, 1);
        }

        [Fact]
        public void AddMuscleGroup_NotEmpty_GrowsSecondaryCollection()
        {
            for (int i = 0; i < 3; i++)
            {
                exercise.AddMuscleGroup(new MuscleGroup());
            }
            Assert.Equal(exercise.SecondaryMuscleGroups.Count, 2);
            Assert.Equal(exercise._exerciseSecondaryMuscleGroups.Count, 2);
        }

        [Fact]
        public void AddMuscleGroup_DuplicatePrimary_ThrowsException()
        {
            var mockM1 = new Mock<MuscleGroup>();
            var mockM2 = new Mock<MuscleGroup>();

            mockM1.Setup(m => m.Id).Returns(1);
            mockM2.Setup(m => m.Id).Returns(1);

            exercise.AddMuscleGroup(mockM1.Object);
            Assert.Throws<InvalidOperationException>(() => exercise.AddMuscleGroup(mockM2.Object));
        }

        [Fact]
        public void AddMuscleGroup_DuplicateSecondary_ThrowsException()
        {
            var mockM1 = new Mock<MuscleGroup>();
            var mockM2 = new Mock<MuscleGroup>();

            mockM1.Setup(m => m.Id).Returns(1);
            mockM2.Setup(m => m.Id).Returns(1);

            exercise.AddMuscleGroup(new MuscleGroup());
            exercise.AddMuscleGroup(mockM1.Object);
            Assert.Throws<InvalidOperationException>(() => exercise.AddMuscleGroup(mockM2.Object));
        }
    }
}
