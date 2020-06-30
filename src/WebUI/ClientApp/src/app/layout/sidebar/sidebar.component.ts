import { Component, OnInit } from '@angular/core';

declare const $: any;
declare interface RouteInfo {
    path: string;
    title: string;
    icon: string;
    class: string;
    child: Array<RouteInfo>;
}
export const ROUTES: RouteInfo[] = [
    { path: '/dashboard', title: 'Dashboard',  icon: 'dashboard', class: '', child: null },
    { path: '/user-profile', title: 'Schedule Training',  icon:'schedule', class: '', child: null },
    { path: '', title: 'Nominations',  icon:'person_add', class: '', 
      child: [
        { path: '', title: 'Self', icon: '', class: '', child: null},
        { path: '', title: 'Manager', icon: '', class: '', child: null}
      ]
    },
    { path: '/typography', title: 'Mark Attendance',  icon:'playlist_add_check', class: '', child: null },
    { path: '/icons', title: 'Training Calendar',  icon:'date_range', class: '', child: null },
    { path: '/maps', title: 'Feedback',  icon:'feedback', class: '', child: null },
    { path: '/notifications', title: 'Settings',  icon:'settings', class: '', 
      child: [
        { path: '/table-list', title: 'Course', icon:'', class: '', child: null},
        { path: '', title: 'Curriculum', icon:'', class: '', child: null},
        { path: '', title: 'Employee', icon:'', class: '', child: null},
        { path: '', title: 'Project', icon:'', class: '', child: null},
        { path: '', title: 'Sub Group', icon:'', class: '', child: null},
        { path: '', title: 'Group', icon:'', class: '', child: null},
        { path: '', title: 'Training Room', icon:'', class: '', child: null},
        { path: '/questions', title: 'Questions', icon:'', class: '', child: null},
        { path: '', title: 'Presentation', icon:'', class: '', child: null},
        { path: '', title: 'Upload Data', icon:'', class: '', child: null},
        { path: '', title: 'Certificates', icon:'', class: '', child: null},
      ] 
    },
    // { path: '/upgrade', title: 'Upgrade to PRO',  icon:'unarchive', class: 'active-pro' },
];

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent implements OnInit {
  menuItems: any[];

  constructor() { }

  ngOnInit() {
    this.menuItems = ROUTES.filter(menuItem => menuItem);
  }
  isMobileMenu() {
      if ($(window).width() > 991) {
          return false;
      }
      return true;
  };
}
