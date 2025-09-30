# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

IAMSNG is an Industrial Asset Management System built using .NET 8 with a Clean Architecture pattern. The solution consists of multiple projects implementing separation of concerns across different layers.

**CRITICAL**: This application is being developed for Department of Defense (DoD) deployment and MUST maintain FIPS 140-3 compliance at all times.

## Architecture

The solution follows Clean Architecture principles with the following project structure:

- **iamsng.Core**: Domain entities and business logic interfaces
- **iamsng.Application**: Application services and use cases  
- **iamsng.Infrastructure**: Data access, external services, and infrastructure concerns
- **iamsng.Shared**: Shared DTOs and common utilities
- **iamsng.API**: ASP.NET Core Web API with OpenAPI support
- **iamsng.Web**: Blazor Server web application for the UI
- **iamsng.UnitTests**: Unit tests using xUnit v3
- **iamsng.IntegrationTests**: Integration tests

## Build Commands

```bash
# Build the entire solution
dotnet build

# Build in Release mode
dotnet build -c Release

# Clean build artifacts
dotnet clean

# Restore NuGet packages
dotnet restore
```

## Running the Applications

```bash
# Run the Web UI (Blazor Server)
dotnet run --project src/iamsng.Web/iamsng.Web.csproj

# Run the API
dotnet run --project src/iamsng.API/iamsng.API.csproj
```

## Testing

```bash
# Run all tests
dotnet test

# Run unit tests only
dotnet test tests/iamsng.UnitTests/iamsng.UnitTests.csproj

# Run integration tests only  
dotnet test tests/iamsng.IntegrationTests/iamsng.IntegrationTests.csproj

# Run tests with detailed output
dotnet test --logger "console;verbosity=detailed"

# Run tests with code coverage
dotnet test --collect:"XPlat Code Coverage"
```

## Key Technologies

### Core Framework
- **.NET 8**: Latest LTS version of .NET
- **ASP.NET Core**: Web API framework with OpenAPI/Swagger support
- **Blazor Server**: Interactive server-side rendering for the web UI

### Database
- **Microsoft SQL Server 2022 Developer Edition**: Primary database (server name: `iamsdb`)
- **Entity Framework Core 8**: ORM for data access with code-first migrations
- **Connection Security**: Windows Authentication (local dev) with encrypted connections
- **FIPS 140-3 Compliance**: All cryptographic operations use FIPS-validated algorithms

### Database Architecture (MANDATORY)

#### Connection Management
- **Development**: User Secrets for credentials (NEVER in appsettings.json)
- **Production**: Azure Key Vault for all secrets
- **Testing**: In-Memory DB for unit tests, LocalDB for integration tests
- **Pooling**: Min=10, Max=100 for optimal performance

#### Performance Stack (USE ALL)
1. **EF Core**: Standard CRUD operations (80% of queries)
2. **Compiled Queries**: Hot paths (2-5x faster) 
3. **Dapper**: Complex reports (10x faster)
4. **Redis Cache**: Repeated queries (100x faster)

#### Required Patterns
- **Repository Pattern**: MANDATORY for security boundary and audit
- **Unit of Work**: MANDATORY for transaction integrity
- **Specification Pattern**: MANDATORY for complex reusable queries

#### Code-First Approach
- **Migrations**: Track all schema changes with audit trail
- **Temporal Tables**: Enable for DoD compliance history
- **Indexes**: Define in migrations for performance
- **Security**: Use data annotations for classification

### Testing
- **xUnit v3**: Modern testing framework with improved async support

### Architecture
- **Clean Architecture**: Separation of concerns across domain, application, and infrastructure layers

## Development Workflow

When implementing new features:

1. Start with domain entities in `iamsng.Core`
2. Define application services in `iamsng.Application`  
3. Implement data access in `iamsng.Infrastructure`:
   - Create repository interface in Core
   - Implement repository with security/audit in Infrastructure
   - Add specifications for complex queries
   - Configure compiled queries for performance
4. Expose endpoints in `iamsng.API` or UI components in `iamsng.Web`
5. Write unit tests in `iamsng.UnitTests`:
   - Use In-Memory database for fast tests
   - Mock repositories for domain logic tests
6. Add integration tests in `iamsng.IntegrationTests`:
   - Use LocalDB for SQL-specific features
   - Test full data access stack with UoW

## Project Dependencies

- Core layer has no external dependencies
- Application layer depends on Core
- Infrastructure depends on Core and Application
- API and Web depend on all layers
- Shared can be referenced by any layer for DTOs

This ensures dependency flow follows Clean Architecture principles with dependencies pointing inward.

## Security Requirements

### FIPS 140-3 Compliance
- All cryptographic operations MUST use FIPS 140-3 validated algorithms
- TLS 1.2 or higher for all network communications
- SQL Server connections must use encryption (Encrypt=True)
- No sensitive data in logs or error messages

### DoD Standards
- Follow DISA STIGs for application security
- Implement audit logging for all data access
- Support for CAC authentication in production
- Row-level security for multi-tenant isolation

## Documentation

All project documentation is maintained in the `docs/` folder:
- `DATABASE-SETUP.md` - SQL Server configuration and setup
- `SECURITY-COMPLIANCE.md` - Security requirements and implementation
- `TECHNOLOGY-STACK.md` - Complete technology inventory
- `PROJECT-CHANGES-LOG.md` - Development history and changes

**Important**: When generating new documentation, always save it to the `docs/` folder.

## CRITICAL: Continuous Documentation Requirements

### MANDATORY: Continuous Documentation Agent

**A continuous documentation agent MUST be running at ALL times during development.**

#### The Continuous Documentation System:

1. **Primary Agent**: `docs-architect` or `tutorial-engineer`
   - Launch at session start
   - Keep active throughout entire session
   - Re-launch if terminated

2. **Master Timeline Updates** (MANDATORY for EVERY change):
   - **File**: `docs/MASTER-PROJECT-TIMELINE.md`
   - **Update Frequency**: IMMEDIATELY after each change
   - **Required Info**: Date, time, files, packages, rationale, FIPS impact
   - **Format**: Chronological with full traceability

3. **Automatic Documentation Triggers**:
   ```
   ON: File creation → Document purpose and structure
   ON: Package addition → Document version and security scan
   ON: Configuration change → Document impact and rollback
   ON: API endpoint → Generate OpenAPI spec
   ON: Database change → Document migration and impact
   ON: Security implementation → Document compliance validation
   ```

4. **Documentation Validation**:
   - Every code change MUST have timeline entry
   - Every feature MUST have technical documentation
   - Every security control MUST have compliance notes
   - Every API MUST have OpenAPI specification
   - Every database change MUST have migration guide

### Master Project Timeline Rules

**The MASTER-PROJECT-TIMELINE.md is the authoritative project history.**

#### What MUST be Recorded:
- ✅ Every file created/modified (with full path)
- ✅ Every package added/updated (with exact version)
- ✅ Every architecture decision (with rationale)
- ✅ Every security implementation (with FIPS note)
- ✅ Every database change (with migration)
- ✅ Every API endpoint (with security)
- ✅ Every configuration change
- ✅ Every test added
- ✅ Every agent deployment
- ✅ Session start/end times

#### Update Pattern:
```
1. Make code change
2. IMMEDIATELY update timeline
3. Trigger documentation agent
4. Verify documentation generated
5. Continue to next task
```

#### Example Continuous Workflow:
```
# Session Start
1. Launch: docs-architect "Monitor and document all changes"
2. Update: MASTER-PROJECT-TIMELINE.md with session start

# During Development  
[Make changes]
→ Timeline updated automatically
→ Documentation generated in parallel
→ No manual documentation needed

# Session End
1. Verify: All changes in timeline
2. Verify: All docs generated
3. Commit: Include timeline in commit
```

### Documentation Agent Commands

```bash
# Start continuous documentation (RUN FIRST)
Task: docs-architect "Continuously monitor and document all project changes to docs/ folder. Update MASTER-PROJECT-TIMELINE.md with every change."

# Verify documentation is current
Task: docs-architect "Validate all recent changes are documented in MASTER-PROJECT-TIMELINE.md"

# Generate missing documentation
Task: docs-architect "Scan for undocumented changes and update timeline"
```

**FAILURE TO MAINTAIN CONTINUOUS DOCUMENTATION IS A CRITICAL VIOLATION**

This is required for:
- DoD audit compliance
- Change traceability
- Security validation
- Project history
- Knowledge transfer

#### Mode Independence:
The continuous documentation agent operates independently of interaction modes:
- Remains active during `/interactive` mode
- Continues timeline updates in both modes
- Documents all changes regardless of current mode
- Never pauses or stops documentation

## Compact Conversation Handling

### AUTOMATIC CONTEXT REFRESH PROTOCOL

When a conversation is compacted (via `/compact` command or automatic compaction), the agent MUST:

1. **Immediate Context Review** (MANDATORY):
   - Review the conversation summary provided
   - Check the most recent 5-10 messages for current work
   - Identify any in-progress tasks or pending operations
   - Note the current development phase and objectives

2. **Documentation Refresh** (REQUIRED):
   - Re-read CLAUDE.md for current project guidelines
   - Check MASTER-PROJECT-TIMELINE.md for recent changes
   - Review any active documentation in `docs/` folder
   - Verify current database state and migrations

3. **State Verification**:
   - Check git status for uncommitted changes
   - Verify build status (no errors)
   - Review any active todo items
   - Confirm current interaction mode (/interactive or /devmode)

4. **Continuation Strategy**:
   - Resume exactly where the conversation left off
   - Maintain consistency with previous decisions
   - Honor any architectural patterns already established
   - Continue using the same naming conventions

5. **Auto-Recovery Actions**:
   ```
   # On Compact Detection:
   1. Parse conversation summary
   2. Extract key entities/tables/features mentioned
   3. Verify current state matches summary
   4. Load relevant configurations
   5. Resume development flow seamlessly
   ```

### Compact Trigger Behaviors

The agent should automatically detect compaction through:
- Conversation summary at session start
- "compacted" message in local command output
- Missing context from previous messages
- Session continuation indicators

### Post-Compact Checklist:
```
□ Conversation summary reviewed
□ CLAUDE.md re-read
□ Current git status checked
□ Database migrations verified
□ Todo list synchronized
□ Documentation agent status confirmed
□ Interaction mode identified
□ Development flow resumed
```

**IMPORTANT**: After compaction, never ask the user to re-explain completed work. Use the summary and documentation to maintain continuity.

## User Interaction Modes

### COMMAND: /interactive
When the user enters `/interactive`, immediately switch to Interactive Mode:
- **STOP** all automatic code generation
- **ASK** before creating any files or entities
- **PRESENT OPTIONS** for each decision point
- **WAIT** for explicit user approval before proceeding
- Use question-answer format for all development decisions
- Example flow:
  1. "What type of entity would you like to create?"
  2. "What properties should it have?"
  3. "Should it inherit from BaseEntity?"
  4. "Here's what I'll create: [preview]. Proceed?"

### COMMAND: /devmode
When the user enters `/devmode`, return to Development Mode:
- Resume normal autonomous development operations
- Create files and code as needed
- Use agents for parallel tasks
- Make decisions based on best practices

### Important Notes:
- **Documentation Agent**: Remains ACTIVE in both modes
- **Timeline Updates**: Continue regardless of mode
- **Default Mode**: Development Mode (normal operations)
- **Mode Persistence**: Mode remains until explicitly changed
- **Current Mode Indicator**: Always acknowledge mode switches

## Development Workflow Rules

### MANDATORY: Agent-Based Asynchronous Development

**ALWAYS use specialized agents for parallel task execution.** This maximizes efficiency and ensures comprehensive coverage.

#### When to Use Agents (Required):

1. **Multi-File Operations**
   - Use agents when modifying 3+ files
   - Launch multiple agents for independent tasks
   - Example: `database-architect` for schema + `backend-architect` for API design

2. **Complex Analysis Tasks**
   - Code reviews: ALWAYS use `code-reviewer` agent after significant changes
   - Security audits: Use `security-auditor` for all authentication/authorization code
   - Performance analysis: Use `performance-engineer` for optimization tasks

3. **Documentation Generation**
   - Use `docs-architect` for comprehensive documentation
   - Use `tutorial-engineer` for user guides
   - Launch asynchronously while continuing development

4. **Testing Implementation**
   - Use `test-automator` for test generation
   - Run `tdd-orchestrator` for TDD workflow enforcement
   - Execute tests with agents while developing features

5. **Research and Discovery**
   - Use `search-specialist` for codebase exploration
   - Deploy multiple agents for parallel research
   - Example: Architecture review + dependency analysis simultaneously

#### Agent Execution Patterns:

```
# CORRECT - Parallel execution
1. Launch database-architect agent for schema design
2. Launch api-documenter agent for OpenAPI specs
3. Launch test-automator for test generation
4. Continue with main development task

# INCORRECT - Sequential execution
1. Complete database schema
2. Then write API documentation  
3. Then write tests
4. Then continue development
```

### MANDATORY: MCP Server Utilization

**ALWAYS leverage MCP servers when available.** These provide enhanced capabilities beyond standard tools.

#### Required MCP Server Usage:

1. **GitHub Operations** (`mcp__github__`)
   - MUST use for all GitHub interactions
   - Creating/updating files in remote repos
   - Managing PRs, issues, and branches
   - Never use git commands when MCP GitHub is available

2. **Browser Automation** (`mcp__server-puppeteer__` / `mcp__browser-tools__`)
   - REQUIRED for web testing and validation
   - UI verification and screenshot capture
   - Performance and accessibility audits
   - SEO and security checks

3. **Documentation Research** (`mcp__context7__`)
   - MANDATORY for library documentation lookups
   - Always check latest docs before implementing
   - Use for framework best practices

4. **Security Scanning** (`mcp__socket__`)
   - REQUIRED for all dependency additions
   - Run before committing package changes
   - Verify security scores meet DoD requirements

5. **Code Intelligence** (`mcp__serena__`)
   - PREFERRED over basic file operations
   - Use for semantic code search
   - Leverage for intelligent refactoring
   - Memory management for project context

#### MCP Server Priority Rules:

```
# Priority Order (MUST follow):
1. MCP server tool (if available)
2. Specialized agent (for complex tasks)
3. Standard tool (only if no MCP/agent option)

# Example:
✅ Use: mcp__github__create_pull_request
❌ Avoid: gh pr create (bash command)

✅ Use: mcp__serena__find_symbol  
❌ Avoid: grep or manual search

✅ Use: mcp__browser-tools__ for UI testing
❌ Avoid: Manual browser testing
```

### Interaction Mode Compliance

**ALWAYS check for mode commands first:**
- `/interactive` = Switch to collaborative Q&A mode
- `/devmode` = Switch to autonomous development
- Respect current mode throughout session
- Mode changes are immediate and persistent

### Workflow Enforcement:

1. **Before Starting Any Task**:
   - Check for mode commands (`/interactive` or `/devmode`)
   - Check available MCP servers
   - Identify parallelizable subtasks
   - Launch appropriate agents

2. **During Development**:
   - Run security agents continuously
   - Keep documentation agents active
   - Use test agents in parallel

3. **Before Completion**:
   - MUST run code-reviewer agent
   - MUST check with security-auditor
   - MUST validate with relevant MCP tools

### Performance Metrics:

- **Target**: 3-5 agents running simultaneously
- **Minimum**: 2 parallel operations for complex tasks
- **Required**: 100% MCP server usage when applicable

**CRITICAL**: Failure to use agents and MCP servers when available is considered a development antipattern and must be corrected immediately.

### Enforcement Checklist (EVERY Session):

```
□ Continuous documentation agent launched
□ MASTER-PROJECT-TIMELINE.md updated with session start
□ All MCP servers checked and available
□ Parallel agents ready for deployment
□ Security validation agent on standby
□ Timeline updates after EVERY change
□ Documentation generated for EVERY feature
□ Session end documented in timeline
```

**Remember**: The timeline is the official record for DoD presentation. Missing entries = audit failure.