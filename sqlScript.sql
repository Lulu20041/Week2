
CREATE DATABASE task_manager;

CREATE TABLE tasks (
Id INT PRIMARY KEY IDENTITY(1,1),
Title NVARCHAR(100),
Description NVARCHAR(1000),
IsCompleted BIT,
CreatedAt DATETIME
);

INSERT INTO tasks (Title, Description, IsCompleted, CreatedAt)
VALUES
(N'Write documentation', N'Prepare user guide and API reference for the new module.', 0, '2025-10-01 090000'),
(N'Fix login bug', N'Resolve issue where users cannot log in with special characters in password.', 1, '2025-10-02 143000'),
(N'Design database schema', N'Create normalized schema for inventory management system.', 0, '2025-10-03 111500'),
(N'Code review', N'Review pull request #42 and suggest improvements.', 1, '2025-10-04 164500'),
(N'Optimize SQL queries', N'Reduce execution time of reports by indexing and rewriting queries.', 0, '2025-10-05 100000'),
(N'Update dependencies', N'Upgrade NuGet packages to latest stable versions.', 1, '2025-10-05 132000'),
(N'Prepare presentation', N'Draft slides for upcoming team meeting on project status.', 0, '2025-10-06 083000'),
(N'Implement logging', N'Add structured logging to critical components using Serilog.', 0, '2025-10-06 120000'),
(N'Test new features', N'Write unit and integration tests for recent feature additions.', 1, '2025-10-06 154500'),
(N'Merge branches', N'Merge feature branch into main after successful testing.', 1, '2025-10-06 180000');

SELECT  FROM tasks;