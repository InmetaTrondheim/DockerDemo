import { Component, OnInit } from '@angular/core';
import { Person } from '../model/person';
import { DataService } from '../services/dataService';
import { Router } from '@angular/router';

@Component({
  selector: 'app-people',
  templateUrl: './people.component.html',
  styleUrls: ['./people.component.css']
})
export class PeopleComponent implements OnInit {

  people: Person[];

  constructor(private dataService: DataService, private router: Router) { }

  ngOnInit() {
    this.dataService.getPeople().subscribe(r => this.people = r, error => console.log(error.message));
  }

  onAdd() {
    this.router.navigate(['addPerson']);
  }
}
