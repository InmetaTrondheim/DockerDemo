import { Component, OnInit } from '@angular/core';
import { Person } from '../model/person';
import { DataService } from '../services/dataService';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-person',
  templateUrl: './add-person.component.html',
  styleUrls: ['./add-person.component.css']
})
export class AddPersonComponent implements OnInit {

  name: string;
  age: number;

  constructor(private dataService: DataService, private router: Router) { }

  ngOnInit() {
  }

  onSubmit() {
    const person = new Person();
    person.name = this.name;
    person.age = this.age;
    this.dataService.addPerson(person).subscribe(r => this.router.navigate(['']), error => console.log(error.message));
  }

}
