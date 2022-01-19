import { Component, OnInit } from '@angular/core';
import { User } from '../User';
import { UserService } from '../user.service';

@Component({
  selector: 'app-edit-profile',
  templateUrl: './edit-profile.component.html',
  styleUrls: ['./edit-profile.component.css'],
  providers: [UserService]
})
export class EditProfileComponent implements OnInit {

  userToEdit: User = this.userService.getUser();
  constructor(private userService: UserService) { }

  ngOnInit(): void {
  }
  UpdateUser(): void {
    let name: string = (<HTMLInputElement>document.getElementById("Name")).value;
    let contact: string = (<HTMLInputElement>document.getElementById("Contact")).value;
    let bio: string = (<HTMLInputElement>document.getElementById("Bio")).value;
    this.userService.setUser(name, contact, bio);
  }
}
