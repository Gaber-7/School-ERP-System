INSERT INTO Page
(ID, En_name, Ar_name, Icon, [Order], IsDisplay, IsActive)
VALUES

(1, 'Administration', N'الإدارة', 'fa-solid fa-users', 1, 1, 1),

(2, 'Inventory', N'المخازن', 'fa-solid fa-box', 2, 1, 1),

(3, 'Communication', N'التواصل', 'fa-solid fa-comments', 3, 1, 1),

(4, 'Accounting', N'الحسابات', 'fa-solid fa-calculator', 4, 1, 1),

(5, 'Management System', N'نظام الإدارة', 'fa-solid fa-chart-line', 5, 1, 1),

(6, 'Settings', N'الإعدادات', 'fa-solid fa-gear', 6, 1, 1),

(7, 'Registration', N'التسجيل', 'fa-solid fa-clipboard-check', 7, 1, 1),

(8, 'HR', N'الموارد البشرية', 'fa-solid fa-user-group', 8, 1, 1)


INSERT INTO Page
(ID, En_name, Ar_name, Icon, [Order], IsDisplay, IsActive, Page_ID)
VALUES

(18, 'Section',     N'الأقسام الفرعية', 'fa-solid fa-layer-group', 9, 1, 1, 1),
(19, 'AcademicYears', N'السنوات الدراسية', 'fa-solid fa-calendar', 10, 1, 1, 1);