import { Component, OnInit } from '@angular/core';
import { User } from '../User';
import { UserService } from '../user.service';

@Component({
  selector: 'app-profile-display',
  templateUrl: './profile-display.component.html',
  styleUrls: ['./profile-display.component.css'],
  providers: [UserService]
})
export class ProfileDisplayComponent implements OnInit {

  currentUser: User = this.userService.getUser();

  //Inject the user service class
  constructor(private userService: UserService) { }

  ngOnInit(): void {
  }

}
