import { Component } from '@angular/core';
import { EmployeeService } from './employee.service';
import { Employee } from './Model/Employee';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'httpclientExample';
  empList: Employee[] = [

  ]
  constructor(private _service: EmployeeService) {
  }
  ngOnInit() {
    this._service.GetEmployees().subscribe(data => { this.empList = data,console.log(this.empList) }
      
    );
  }
}
