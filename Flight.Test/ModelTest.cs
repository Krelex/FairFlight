using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Flight.Model;

namespace Flight.Test
{
    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        public void CanCountPassangerNumber_SearchResponeDTO_ReturnDouble()
        {
            // Arrange
            var objectResponeDRO = new FlightSearchResponeDTO()
            {
                Childs = 2,
                Adults = 5,
            };


            // Act
            var result = objectResponeDRO.PassangerNumber();
            const double expected = 7;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CanGetOriginIATA_FlightBoundDTO_ReturnString()
        {
            // Arrange
            var objectBoundDto = new FlightBoundDTO()
            {
                Flights = new List<FlightSegmentDTO>()
                {
                    new FlightSegmentDTO()
                    {
                        Origin = "LON"
                    },
                    new FlightSegmentDTO()
                    {
                        Origin = "LIS"
                    },
                    new FlightSegmentDTO()
                    {
                        Origin = "BOS"
                    },
                }
            };

            // Act
            var result = objectBoundDto.OriginIATA();
            const string expected = "LON";

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CanGetDestinationIATA_FlightBoundDTO_ReturnString()
        {
            // Arrange
            var objectBoundDto = new FlightBoundDTO()
            {
                Flights = new List<FlightSegmentDTO>()
                {
                    new FlightSegmentDTO()
                    {
                        Destination = "LON"
                    },
                    new FlightSegmentDTO()
                    {
                        Destination = "LIS"
                    },
                    new FlightSegmentDTO()
                    {
                        Destination = "BOS"
                    },
                }
            };


            // Act
            var result = objectBoundDto.DestinationIATA();
            const string expected = "BOS";

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CanGetOutboundFlights_SearchResultDTO_ReturnInt()
        {
            // Arrange
            var objectResultDto = new FlightSearchResultDTO()
            {
                Itineraries = new List<FlightItinearyDTO>()
                {
                    new FlightItinearyDTO()
                    {
                        Outbound = new FlightBoundDTO()
                        {
                            Flights = new List<FlightSegmentDTO>()
                            {
                                new FlightSegmentDTO(),
                                new FlightSegmentDTO(),
                                new FlightSegmentDTO()
                            }
                        }
                    }
                }
            };


            // Act
            var result = objectResultDto.FlightNumbersOutbound();
            const int expected = 2;


            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CanGetInboundFlights_SearchResultDTO_ReturnInt()
        {
            // Arrange
            var objectResultDto = new FlightSearchResultDTO()
            {
                Itineraries = new List<FlightItinearyDTO>()
                {
                    new FlightItinearyDTO()
                    {
                        Outbound = new FlightBoundDTO()
                        {
                            Flights = new List<FlightSegmentDTO>()
                            {
                                new FlightSegmentDTO(),
                                new FlightSegmentDTO(),
                                new FlightSegmentDTO()
                            }
                        },
                        Inbound = new FlightBoundDTO()
                        {
                            Flights = new List<FlightSegmentDTO>()
                            {
                                new FlightSegmentDTO(),
                                new FlightSegmentDTO(),
                                new FlightSegmentDTO(),
                                new FlightSegmentDTO(),
                                new FlightSegmentDTO()
                            }
                        }
                    }
                }
            };


            // Act
            var result = objectResultDto.FlightNumbersInbound();
            const int expected = 4;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CanGetOutboundDestination_SearchResultDTO_ReturnString()
        {
            // Arrange
            var objectResultDto = new FlightSearchResultDTO()
            {
                Itineraries = new List<FlightItinearyDTO>()
                {
                    new FlightItinearyDTO()
                    {
                        Outbound = new FlightBoundDTO()
                        {
                            Flights = new List<FlightSegmentDTO>()
                            {
                                new FlightSegmentDTO()
                                {
                                    Origin = "LON",
                                    Destination = "LIS"
                                },
                                new FlightSegmentDTO()
                                {
                                    Origin = "LIS",
                                    Destination = "MOW"
                                },
                                new FlightSegmentDTO()
                                {
                                    Origin = "MOW",
                                    Destination = "BOS"
                                }
                            }
                        }
                    }
                }
            };


            // Act
            var result = objectResultDto.OutboundDestinationIATA();
            const string expected = "BOS";


            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CanGetOutboundOrigin_SearchResultDTO_ReturnString()
        {
            // Arrange
            var objectResultDto = new FlightSearchResultDTO()
            {
                Itineraries = new List<FlightItinearyDTO>()
                {
                    new FlightItinearyDTO()
                    {
                        Outbound = new FlightBoundDTO()
                        {
                            Flights = new List<FlightSegmentDTO>()
                            {
                                new FlightSegmentDTO()
                                {
                                    Origin = "LON",
                                    Destination = "LIS"
                                },
                                new FlightSegmentDTO()
                                {
                                    Origin = "LIS",
                                    Destination = "MOW"
                                },
                                new FlightSegmentDTO()
                                {
                                    Origin = "MOW",
                                    Destination = "BOS"
                                }
                            }
                        }
                    }
                }
            };

            // Act
            var result = objectResultDto.OutboundOriginIATA();
            const string expected = "LON";

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
