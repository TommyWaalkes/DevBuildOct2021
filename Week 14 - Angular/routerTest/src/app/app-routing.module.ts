import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TempComponent } from './temp/temp.component';
import { TestComponent } from './test/test.component';

const routes: Routes = [
  //Any component we wish to route, we MUST import
  { path: "test", component: TestComponent },
  { path: "weather", component: TempComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
