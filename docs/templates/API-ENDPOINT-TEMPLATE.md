# API Endpoint: [ENDPOINT_NAME]

> Template Version: 1.0.0  
> Last Updated: [DATE]  
> Session: [SESSION_ID]  
> FIPS Compliance: [YES/NO/PENDING]

---

## Endpoint Overview

**Path**: `[HTTP_METHOD] /api/[path]`  
**Version**: v[1]  
**Purpose**: [Brief description of what this endpoint does]  
**Category**: [CRUD/Query/Command/Integration]  
**Authentication**: [Required/Optional/None]  
**Authorization**: [Roles/Permissions required]

---

## Request Specification

### Headers
```http
Content-Type: application/json
Authorization: Bearer [token]
X-Request-ID: [GUID]
```

### Parameters

#### Path Parameters
| Name | Type | Required | Description | Validation |
|------|------|----------|-------------|------------|
| id | [type] | [Yes/No] | [Description] | [Rules] |

#### Query Parameters
| Name | Type | Required | Default | Description | Validation |
|------|------|----------|---------|-------------|------------|
| [param] | [type] | [Yes/No] | [value] | [Description] | [Rules] |

### Request Body
```json
{
  "property1": "value",
  "property2": 123
}
```

#### Body Schema
| Field | Type | Required | Description | Validation | FIPS Note |
|-------|------|----------|-------------|------------|-----------|
| [field] | [type] | [Yes/No] | [Description] | [Rules] | [Compliance note] |

---

## Response Specification

### Success Response

**Status Code**: `[200/201/204]`

#### Response Headers
```http
Content-Type: application/json
X-Request-ID: [GUID]
X-Rate-Limit-Remaining: [number]
```

#### Response Body
```json
{
  "success": true,
  "data": {
    "id": "123",
    "property": "value"
  },
  "metadata": {
    "timestamp": "2025-01-28T00:00:00Z",
    "version": "1.0"
  }
}
```

### Error Responses

#### 400 Bad Request
```json
{
  "success": false,
  "error": {
    "code": "VALIDATION_ERROR",
    "message": "Invalid input parameters",
    "details": []
  }
}
```

#### 401 Unauthorized
```json
{
  "success": false,
  "error": {
    "code": "UNAUTHORIZED",
    "message": "Authentication required"
  }
}
```

#### 403 Forbidden
```json
{
  "success": false,
  "error": {
    "code": "FORBIDDEN",
    "message": "Insufficient permissions"
  }
}
```

#### 404 Not Found
```json
{
  "success": false,
  "error": {
    "code": "NOT_FOUND",
    "message": "Resource not found"
  }
}
```

#### 500 Internal Server Error
```json
{
  "success": false,
  "error": {
    "code": "INTERNAL_ERROR",
    "message": "An unexpected error occurred",
    "reference": "[error_id]"
  }
}
```

---

## Security Controls

### Authentication
- **Method**: [JWT/CAC/Certificate]
- **Token Lifetime**: [duration]
- **Refresh Strategy**: [description]

### Authorization
- **Required Roles**: [list]
- **Required Permissions**: [list]
- **Data Access Control**: [description]

### Input Validation
- [ ] SQL Injection prevention
- [ ] XSS prevention
- [ ] Command injection prevention
- [ ] Path traversal prevention
- [ ] File upload validation (if applicable)

### Rate Limiting
- **Requests per minute**: [number]
- **Requests per hour**: [number]
- **Burst limit**: [number]

### Audit Logging
- **Events Logged**:
  - [ ] Request received
  - [ ] Authentication attempt
  - [ ] Authorization check
  - [ ] Data access
  - [ ] Response sent
  - [ ] Errors/Exceptions

### FIPS 140-3 Compliance
- **Encryption in Transit**: TLS 1.2+ required
- **Encryption at Rest**: AES-256 for sensitive data
- **Cryptographic Operations**: FIPS-approved algorithms only
- **Key Management**: [Description of key handling]

---

## Implementation Details

### Controller
- **File**: `src/iamsng.API/Controllers/[Controller].cs`
- **Class**: `[ControllerName]Controller`
- **Method**: `[MethodName]`

### Service Layer
- **Interface**: `I[ServiceName]Service`
- **Implementation**: `[ServiceName]Service`
- **File**: `src/iamsng.Application/Services/[Service].cs`

### Data Access
- **Repository**: `I[Entity]Repository`
- **DbContext Method**: `[MethodName]`
- **SQL Query/EF Query**: [if applicable]

### Validation
- **Validator Class**: `[Request]Validator`
- **Validation Rules**: [list key rules]

---

## Testing

### Unit Tests
- **Test File**: `tests/iamsng.UnitTests/Controllers/[Controller]Tests.cs`
- **Coverage**: [percentage]
- **Key Test Cases**:
  - [ ] Valid request processing
  - [ ] Invalid input rejection
  - [ ] Authorization enforcement
  - [ ] Error handling

### Integration Tests
- **Test File**: `tests/iamsng.IntegrationTests/[Endpoint]Tests.cs`
- **Scenarios Tested**:
  - [ ] End-to-end flow
  - [ ] Database interaction
  - [ ] External service calls
  - [ ] Concurrent requests

### Security Tests
- [ ] Penetration testing completed
- [ ] OWASP Top 10 validated
- [ ] FIPS compliance verified
- [ ] DoD STIG compliance checked

---

## Performance Metrics

| Metric | Target | Current | Status |
|--------|--------|---------|--------|
| Response Time (p50) | <100ms | [value] | [✅/🔴] |
| Response Time (p95) | <500ms | [value] | [✅/🔴] |
| Response Time (p99) | <1000ms | [value] | [✅/🔴] |
| Throughput | >100 req/s | [value] | [✅/🔴] |
| Error Rate | <0.1% | [value] | [✅/🔴] |

---

## Dependencies

### Internal Dependencies
- `iamsng.Core`: [Entities used]
- `iamsng.Application`: [Services used]
- `iamsng.Infrastructure`: [Repositories used]

### External Dependencies
- [List any external services/APIs]

### Package Dependencies
- [List NuGet packages with versions]

---

## OpenAPI Specification

```yaml
/api/[path]:
  [method]:
    summary: [Brief description]
    operationId: [operationId]
    tags:
      - [tag]
    security:
      - bearerAuth: []
    parameters:
      - name: [param]
        in: [path/query/header]
        required: [true/false]
        schema:
          type: [type]
    requestBody:
      required: [true/false]
      content:
        application/json:
          schema:
            $ref: '#/components/schemas/[Schema]'
    responses:
      '200':
        description: Success
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/[ResponseSchema]'
      '400':
        $ref: '#/components/responses/BadRequest'
      '401':
        $ref: '#/components/responses/Unauthorized'
      '500':
        $ref: '#/components/responses/InternalError'
```

---

## Change History

| Date | Session | Change | Author | Review Status |
|------|---------|--------|--------|---------------|
| [DATE] | [SESSION] | Initial documentation | [Agent/Developer] | Pending |

---

## Compliance Checklist

- [ ] FIPS 140-3 compliant encryption
- [ ] DoD STIG requirements met
- [ ] NIST 800-53 controls implemented
- [ ] OWASP security guidelines followed
- [ ] Audit logging configured
- [ ] Error handling implemented
- [ ] Input validation complete
- [ ] Rate limiting configured
- [ ] Documentation reviewed
- [ ] Security review completed

---

## Notes

[Any additional notes, known issues, or future improvements]

---

*Generated by: Continuous Documentation Agent*  
*Template Version: 1.0.0*  
*Compliance Target: DoD IL4*