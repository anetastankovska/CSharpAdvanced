1. Create one abstract class Vehicle with abstract method Drive, and two classes Car and Truck that inherit from Vehicle and override the method Drive.
2. Create 3 interfaces:
- ICarWash that has methods WashCar that works for Cars, and WashTrailer that works for Trailers.
- IGasPump that has method PumpGas that works for all vehicles
- IRepairService that has methods CheckVehicle and FixVehicle that work for all vehicles.
3. Implement each interface in a different class: CarWash, GasPump and RepairService.
4. Implement all interfaces in one class CarCenter.
5. Methods can be implemented with Console.Writeline or changing and checking bools (ex. isClean, isGasFull, isBroken...)