from abc import ABC, abstractmethod

# class Samochod:
#     def __init__   (self, marka, model, rok):
#         self.__marka = marka
#         self._model = model
#         self.rok = rok

#     def wypisz(self):  
#         return f"{self.marka} {self.model} {self.rok}"
    
# wozik = Samochod(marka:"a" , model:"a" , rok:2000)
# print(wozik.wypisz())

# class Pojazd(Samochod, KlasaB, KlasaC):
#     def __init__(self, marka, model, rok, a):
#         super().__init__(marka, model, rok)
#         self.a = a;
        

# class Zwierze(ABC):
#     @abstractmethod
#     def dzwiek(self):
#         pass

# class Kot(Zwierze):
#     def dzwiek(self):
#         return "Miau"

# class Pies(Zwierze):
#     def dzwiek(self):
#         return "Hau"


class Employee:
    def __init__(self, name: str, age: int, salary: float):
        self.name = name
        self.age = age
        self.salary = salary

    def__str__(self):
        return f"Name: {self.name} Age: {self.age} Salary: {self.salary}"

class EmpolyeesManager:
    def __init__(self):
        self.employees = []

    def update_salary(self, new_salary: float):
        self.salary = new.salary
    
    def add_employee(self, employee: Employee):
        self.employees.append(employee)
    
    def list_employees(self):
        if not self.employees:
            print("No employees")
        else:
            for emp in self.employees:
                print(emp)

    def remove_employees_by_age_range(self, min_age: int, max_age: int):
        initial_count = len(self.employee)
        self.employees = [emp for emp in self.employees if not (min_age <= emp.age <= max_removed_count = initial count - len(self.employees))]

    def find_employee_by_name(self, name:str):
        for emp in self.employees:
            if emp.name == name:
                return emp
        print(f"Employee with name '{name}' not found.")
        return None
    
    def update_salary_by_name(self, name: str, new_salary: float):
        employee = self.find_employee_by_name(name)
        if employee:
            employee.update_salary(new_salary)
            print(f"Updated salary for {name} to {new_salary}.")
        else:
            print(f"Could not find employee with {name} to update salary.")