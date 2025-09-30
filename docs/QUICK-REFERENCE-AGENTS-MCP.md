# Quick Reference: Agents & MCP Servers

## 🚀 MANDATORY Usage Rules

### Always Use Agents For:
- [ ] Code changes affecting 3+ files
- [ ] Security implementations
- [ ] Database schema changes
- [ ] API endpoint creation
- [ ] Test generation
- [ ] Documentation updates

### Always Use MCP Servers For:
- [ ] GitHub operations → `mcp__github__`
- [ ] Browser testing → `mcp__browser-tools__`
- [ ] Library docs → `mcp__context7__`
- [ ] Dependency security → `mcp__socket__`
- [ ] Code search → `mcp__serena__`

## ⚡ Common Parallel Workflows

### Feature Implementation
```
PARALLEL:
1. backend-architect → API design
2. database-architect → Schema design  
3. test-automator → Test generation
4. docs-architect → Documentation
```

### Security Review
```
PARALLEL:
1. security-auditor → Code audit
2. backend-security-coder → Fix vulnerabilities
3. mcp__socket__ → Dependency scan
4. code-reviewer → Final review
```

### Database Change
```
PARALLEL:
1. database-architect → Schema update
2. database-admin → Migration plan
3. performance-engineer → Impact analysis
4. test-automator → Integration tests
```

## 🔧 MCP Server Priority

| Task | First Choice | Fallback |
|------|--------------|----------|
| File search | `mcp__serena__find_symbol` | `grep` tool |
| GitHub PR | `mcp__github__create_pull_request` | `gh` command |
| Browser test | `mcp__browser-tools__` | Manual test |
| Dependency check | `mcp__socket__depscore` | Manual review |
| Code navigation | `mcp__serena__` | Read tool |

## 🎯 Agent Selection Matrix

| Task Type | Primary Agent | Support Agents |
|-----------|--------------|----------------|
| New Feature | `backend-architect` | `test-automator`, `docs-architect` |
| Bug Fix | `debugger` | `error-detective`, `code-reviewer` |
| Security | `security-auditor` | `backend-security-coder`, `incident-responder` |
| Database | `database-architect` | `database-admin`, `mlops-engineer` |
| API | `api-documenter` | `backend-architect`, `graphql-architect` |
| UI | `frontend-developer` | `ui-ux-designer`, `ui-visual-validator` |
| Performance | `performance-engineer` | `observability-engineer`, `dx-optimizer` |
| Documentation | `docs-architect` | `tutorial-engineer`, `reference-builder` |

## 📊 Performance Targets

- **Minimum**: 2 parallel operations
- **Target**: 3-5 agents simultaneously  
- **MCP Usage**: 100% when available
- **Response Time**: <2s for agent launch
- **Documentation**: Generated within 30s

## 🔴 RED FLAGS (Fix Immediately)

1. ❌ Sequential file edits without agents
2. ❌ Using bash git instead of `mcp__github__`
3. ❌ Manual code search instead of `mcp__serena__`
4. ❌ Adding dependencies without `mcp__socket__`
5. ❌ Completing features without `code-reviewer`
6. ❌ Security code without `security-auditor`
7. ❌ Database changes without impact analysis

## ✅ Success Checklist

Before marking any task complete:
- [ ] Relevant agents were used
- [ ] MCP servers utilized when available
- [ ] Parallel execution achieved
- [ ] Security agent validated (if applicable)
- [ ] Code reviewer agent ran
- [ ] Documentation generated
- [ ] Tests created/updated
- [ ] FIPS 140-3 compliance verified

## 🆘 Quick Commands

```bash
# Check agent status
Task status

# List available MCP servers
ListMcpResourcesTool

# Validate security compliance
Task: security-auditor "Validate FIPS 140-3 compliance"

# Generate documentation
Task: docs-architect "Update project documentation in docs/"

# Full feature workflow
Task: backend-architect "Design new asset tracking feature"
Task: test-automator "Generate tests for asset tracking"
Task: docs-architect "Document asset tracking API"
```

---
**Remember**: Parallel > Sequential | MCP > Standard Tools | Agents > Manual Work