using NUnit.Framework;
using SistemaGestorEventos.BE;
using SistemaGestorEventos.BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.Test.BLL
{
    public class EventsBLLTest
    {
        private EventsBLL target;

        [SetUp]
        public void SetUp()
        {
            target = EventsBLL.Instance;
        }

        [Test]
        public void ValidateEvent_WithoutErros()
        {
            var testedEvent = new Event();
            testedEvent.Title = "Evento de test";
            testedEvent.Description = null;
            testedEvent.MaxBudget = 120;
            testedEvent.MinBudget = testedEvent.MaxBudget;
            testedEvent.DateFrom = DateTime.Now.AddDays(1);
            testedEvent.DateTo = testedEvent.DateFrom.AddHours(4);
            testedEvent.EventType = EventType.Casual;

            var erros = this.target.ValidateEvent(testedEvent);

            Assert.That(erros.Count == 0, "Se espera finalizar la valiidación sin errores");
        }

        [Test]
        public void ValidateEvent_FullErrors()
        {
            var testedEvent = new Event();


            var errors = this.target.ValidateEvent(testedEvent);

            Assert.That(errors.Contains("Ingrese un titulo"));
            Assert.That(errors.Contains("Ingrese una fecha desde mayor a la fecha actual"));
            Assert.That(errors.Contains("Inidique la categoría del evento"));

            testedEvent.MaxBudget = -1000;
            errors = this.target.ValidateEvent(testedEvent);
            Assert.That(errors.Contains("Indique un presupuesto máximo"));

            testedEvent.MaxBudget = 1000;
            testedEvent.MinBudget = testedEvent.MaxBudget + 1;


            errors = this.target.ValidateEvent(testedEvent);
            Assert.That(errors.Contains("El presupuesto minimo no puede ser superior al máximo"));


            testedEvent.DateFrom = DateTime.Now.AddDays(2);
            testedEvent.DateTo = DateTime.Now.AddDays(1);
            errors = this.target.ValidateEvent(testedEvent);
            Assert.That(errors.Contains("La fecha 'hasta' no puede ser menor que la fecha 'desde'"));
            
            Assert.That(errors.Contains("Inidique la categoría del evento"));

            
        }
    }
}
