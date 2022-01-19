import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditProfileComponent } from './edit-profile/edit-profile.component';
import { ProfileDisplayComponent } from './profile-display/profile-display.component';

const routes: Routes = [
  { path: "Display", component: ProfileDisplayComponent },
  { path: "Edit", component: EditProfileComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
